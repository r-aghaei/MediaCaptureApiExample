using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage.Streams;

namespace MediaCaptureApiExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var mediaCapture = new MediaCapture();
            await mediaCapture.InitializeAsync();
            mediaCapture.Failed += (obj, args) => MessageBox.Show(args.Message);

            var lowLagCapture = await mediaCapture.PrepareLowLagPhotoCaptureAsync(
                ImageEncodingProperties.CreateUncompressed(MediaPixelFormat.Bgra8));
            var capturedPhoto = await lowLagCapture.CaptureAsync();
            var softwareBitmap = capturedPhoto.Frame.SoftwareBitmap;
            await lowLagCapture.FinishAsync();
            using (var stream = new InMemoryRandomAccessStream())
            {
                var encoder = await BitmapEncoder.CreateAsync(
                    BitmapEncoder.PngEncoderId, stream);
                encoder.SetSoftwareBitmap(softwareBitmap);
                await encoder.FlushAsync();
                pictureBox1.Image = new Bitmap(stream.AsStream());
            }
        }
    }
}