using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DownloadingFromInternet
{
    public class Utility
    {

        public void LoadPicture()
        {
           
            var request = (HttpWebRequest)WebRequest.Create("https://cdn.pixabay.com/photo/2014/09/05/18/33/old-letters-436501_1280.jpg");
            var stream = request.GetResponse().GetResponseStream();
            using (var file = File.Open(@"D:/picture.jpg", FileMode.Create))
            {
                var bytes = new byte[1024];
                int r;
                while ((r = stream.Read(bytes, 0, bytes.Length)) > 0)
                    file.Write(bytes, 0, r);
            }
            //File.WriteAllBytes(@"logo.png", bytes);

        }

        public void LoadMusic()
        {

        }

        public void PlayMusic()
        {

        }

        public void PauseMusic()
        {

        }

        public void StopMusic()
        {

        }

    }
}
