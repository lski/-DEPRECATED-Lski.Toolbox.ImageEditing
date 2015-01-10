using System.Drawing;
using System.Drawing.Imaging;

namespace Lski.Toolbox.ImageEditing {

    public static class ImageExtensions {

        static ImageExtensions() {
            _resizer = new ImageResizer();
        }

        private static ImageResizer _resizer { get; set; }

        public static Image Resize(this Image image, int size) {
            return _resizer.Resize(image, size);
        }

        public static Image Resize(this Image image, Size size, bool preserveAspectRatio = true) {
            return _resizer.Resize(image, size, preserveAspectRatio);
        }

        public static ImageFormat SaveFormat(this Image img) {
            return _resizer.SaveFormat(img);
        }
    }
}