using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SolidWorks.Interop.sldworks;
using System.IO;

/*
 *
referencia para esse codigo: 
https://stackoverflow.com/questions/53682824/convert-all-solidworks-files-in-folder-to-step-files-macro
 *
 tipos de arquivo solidworks:
http://help.solidworks.com/2019/english/api/swconst/SOLIDWORKS.Interop.swconst~SOLIDWORKS.Interop.swconst.swDocumentTypes_e.html


 */
namespace SolidExport
{
    public partial class Form1 : Form
    {
        static SldWorks swApp;
        public Form1()
        {
            InitializeComponent();
        }

        private void log(string txt)
        {            
            txtLog.AppendText(txt);
            txtLog.AppendText("\r\n");
        }
        private void fn1()
        {
            string directoryName = GetDirectoryName();

            if (directoryName.Length==0 )
            {
                return;
            }

            if (!GetSolidWorks())
            {
                return;
            }

            int i = 0;

            foreach (string fileName in Directory.GetFiles(directoryName))
            {
                if ( fileName.Contains("$") )
                {
                    continue;
                }
                if (Path.GetExtension(fileName).ToLower() == ".sldprt")
                {
                    CreateStepFile(fileName, 1);
                    i += 1;
                }
                else if (Path.GetExtension(fileName).ToLower() == ".sldasm")
                {
                    CreateStepFile(fileName, 2);
                    i += 1;
                }
                else if (Path.GetExtension(fileName).ToLower() == ".slddrw")
                {
                    CreateDwgFile(fileName, 3);
                    i += 1;
                    CreatePdfFile(fileName, 3);
                    i += 1;
                }
                else
                {
                    
                }
            }
            log ( string .Format("Finished converting {0} files", i) );
        }

        void CreateDwgFile(string fileName, int docType)
        {
            int errors = 0;
            int warnings = 0;

            ModelDoc2 swModel = swApp.OpenDoc6(fileName, docType, 1, "", ref errors, ref warnings);

            string stepFile = Path.GetDirectoryName(fileName) + "\\" +  Path.GetFileNameWithoutExtension(fileName) + ".DWG";

            swModel.Extension.SaveAs(stepFile, 0, 1, null, ref errors, ref warnings);

            log("Created DWG file: " + stepFile);

            swApp.CloseDoc(fileName);
        }

        void CreatePdfFile(string fileName, int docType)
        {
            int errors = 0;
            int warnings = 0;

            ModelDoc2 swModel = swApp.OpenDoc6(fileName, docType, 1, "", ref errors, ref warnings);

            string stepFile = Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".PDF";

            swModel.Extension.SaveAs(stepFile, 0, 1, null, ref errors, ref warnings);

            log("Created PDF file: " + stepFile); ;

            swApp.CloseDoc(fileName);
        }

        void CreateStepFile(string fileName, int docType)
        {
            int errors = 0;
            int warnings = 0;

            ModelDoc2 swModel = swApp.OpenDoc6(fileName, docType, 1, "", ref errors, ref warnings);

            string stepFile = Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName), ".STEP");

            swModel.Extension.SaveAs(stepFile, 0, 1, null, ref errors, ref warnings);

            log("Created STEP file: " + stepFile); ;

            swApp.CloseDoc(fileName);
        }

        string GetDirectoryName()
        {

            string s = txtPasta.Text;

            if (Directory.Exists(s))
            {
                return s;
            }

            MessageBox.Show("Directory does not exists, try again");
            return "";
        }

        bool GetSolidWorks()
        {
            try
            {
                swApp = (SldWorks)Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));

                if (swApp == null)
                {
                    throw new NullReferenceException(nameof(swApp));
                }

                if (!swApp.Visible)
                {
                    swApp.Visible = true;
                }

                log("SolidWorks Loaded");
                return true;
            }
            catch (Exception)
            {
                log("Could not launch SolidWorks");
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fn1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                txtPasta.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                txtOutDir.Text = fbd.SelectedPath;
            }
        }
    }
}
