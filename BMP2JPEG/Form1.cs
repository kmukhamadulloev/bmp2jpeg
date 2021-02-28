using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMP2JPEG
{
    public partial class appForm : Form
    {
        public string defaultPath;
        public string appName = "BMP2JPEG";
        public string[] filelist;

        public appForm()
        {
            InitializeComponent();
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            labelDescription.Text = "Drop images here to convert, after conversion\nit will be saved in users picture folder";
            defaultPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString() + "\\BMP2JPEG";
            this.Text = appName;
            checkConvertionFolder(defaultPath);
        }

        private void dropPanel_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Bitmap image format (*.bmp)|*.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filelist = openFile.FileNames;
                bw.RunWorkerAsync();
            }
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            bw.RunWorkerAsync();
        }

        private void visitMyWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dreamicon.ru");
        }

        private void checkFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", defaultPath);
        }

        public void convertBMP2JPEG(string path)
        {
            Bitmap enterFile = new Bitmap(path);
            ImageCodecInfo exitFile = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder quality = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myParameters = new EncoderParameters(1);
            EncoderParameter myParameter = new EncoderParameter(quality, Convert.ToInt64(100));
            myParameters.Param[0] = myParameter;
            enterFile.Save(@defaultPath + "\\bmp2jpeg_" + System.IO.Path.GetFileNameWithoutExtension(path) + "_" + DateTime.UtcNow.ToString("yyyy-MM-dd_hh-mm-ss.fff") + ".jpg", exitFile, myParameters);
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {  
                    return codec;
                }
            }
            return null;
        }

        public static void checkConvertionFolder(string path)
        {
            if (!System.IO.Directory.Exists(path))
                System.IO.Directory.CreateDirectory(path);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= filelist.Length - 1; i++)
            {
                convertBMP2JPEG(filelist[i]);
                bw.ReportProgress(i);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Text = appName + " ♥ " + e.ProgressPercentage.ToString() + " ♥ Doing...";
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = appName + " ♥ Done...";
        }
    }
}
