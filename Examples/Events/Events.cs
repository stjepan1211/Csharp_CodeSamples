using Examples.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples.Events
{
    public class Events
    {
        public static void UseEvents()
        {
            var video = new Video() { Title = "My video" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }

    }

    internal class VideoEncoder
    {
        //if you want send data through event
        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        //if you don't want send data through event
        //public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding {0} video...", video.Title);
            Thread.Sleep(3000);
            Console.WriteLine("Done.");

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }

    internal class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

}
