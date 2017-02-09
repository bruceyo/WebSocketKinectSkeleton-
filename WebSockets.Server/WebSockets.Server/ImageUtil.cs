using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSockets.Server
{
    public class ImageUtil
    {
        /// <summary>
        /// Converts a given image file to byte array.
        /// </summary>
        /// <param name="path">The image full path.</param>
        /// <returns>The byte array representation of the image.</returns>
        public static byte[] ToByteArray(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        return br.ReadBytes((int)fs.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
