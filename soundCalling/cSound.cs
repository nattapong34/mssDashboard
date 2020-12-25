using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace soundCalling
{
    public class cSound
    {
        WMPLib.WindowsMediaPlayer wplayer;
        string path = Environment.CurrentDirectory + @"\sound\";

        //WMPLib.IWMPPlaylist pl;
        BackgroundWorker bgWorker = new BackgroundWorker();

        public static List<String> Playlist = new List<string>();
        bool PlayStateStopped;
        public static void AddToPlaylist(string path)
        {
            if (path.Length>0)
            Playlist.Add(path);
            Console.WriteLine("Queued " + path);
        }
        public  void RunPlaylist()
        {
            try
            {
                Console.WriteLine("play " + Playlist.First());
                PlayStateStopped = false;
                PlayAudioClip(Playlist.First());
                Playlist.Remove(Playlist.First());

            }
            catch
            {
                Console.WriteLine("Playlist is empty.", ConsoleColor.Red);
            }
        }
        public void PlayAudioClip(string path)
        {
            Console.WriteLine("Playing " + path, ConsoleColor.Gray);
            wplayer.controls.stop();
            wplayer.URL = path;
            wplayer.controls.play();
            PlayStateStopped = false;
        }
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
   

            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                //Do your stuff here
                // Do Work
                if (PlayStateStopped && Playlist.Count>0)
                {
                    RunPlaylist();
                }
                Thread.Sleep(50);
                //Console.WriteLine(wplayer.status);
            }
        }

        // This event handler updates the progress.
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update Progress Status to UI
        }

        // This event handler deals with the results of the background operation.
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Finish
        }

        public cSound()
        {
            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
 
           // pl = newPlaylist("Onqueue");

            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);

            bgWorker.RunWorkerAsync();
        }

        void wplayer_PlayStateChange(int NewState)
        {

            switch (NewState)
            {
                case 0:
                    Console.WriteLine("PlayState = wmppsUndefined", ConsoleColor.DarkGray);
                    break;
                case 1:
                    Console.WriteLine("PlayState = wmppsStopped", ConsoleColor.Red);
                    PlayStateStopped = true;
                    break;
                case 2:
                    Console.WriteLine("PlayState = wmppsPaused", ConsoleColor.Yellow);
                    break;
                case 3:
                    Console.WriteLine("PlayState = wmppsPlaying", ConsoleColor.Green);
                    break;
                case 4:
                    Console.WriteLine("PlayState = wmppsScanForward", ConsoleColor.DarkMagenta);
                    break;
                case 5:
                    Console.WriteLine("PlayState = wmppsScanReverse", ConsoleColor.Magenta);
                    break;
                case 6:
                    Console.WriteLine("PlayState = wmppsBuffering", ConsoleColor.Gray);
                    break;
                case 7:
                    Console.WriteLine("PlayState = wmppsWaiting", ConsoleColor.DarkYellow);
                    break;
                case 8:
                    Console.WriteLine("PlayState = wmppsMediaEnded", ConsoleColor.DarkRed);
                    break;
                case 9:
                    Console.WriteLine("PlayState = wmppsTransitioning", ConsoleColor.DarkGray);
                    break;
                case 10:
                    Console.WriteLine("PlayState = wmppsReady", ConsoleColor.Magenta);
                    PlayStateStopped = true;
                    break;
                case 11:
                    Console.WriteLine("PlayState = wmppsReconnecting", ConsoleColor.Magenta);
                    break;
                case 12:
                    Console.WriteLine("PlayState = wmppsLast", ConsoleColor.DarkBlue);
                    break;
            }
        }
        // var playlist = wplayer.newPlaylist(n, "");

        private List<string> readNum(string strNumber)
        {
            string BahtText = "";
            List<string> calling=new List<string>();
            string[] strThaiNumber = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
            string[] callNumber = { "0.mp3", "1.mp3", "2.mp3", "3.mp3", "4.mp3", "5.mp3", "6.mp3", "7.mp3", "8.mp3", "9.mp3", "10.mp3" };
            string[] strThaiPos = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            string[] callPos = { "", "10.mp3", "100.mp3", "", "", "", "" };

            decimal decNumber = 0;
            decimal.TryParse(strNumber, out decNumber);

            if (decNumber == 0)
            {
                calling.Add("0.mp3");
                return calling;
                //return "ศูนย์";
            }

            strNumber = decNumber.ToString("0.00");
            string strInteger = strNumber.Split('.')[0];

            if (strInteger.Length > 13)
                throw new Exception("รองรับตัวเลขได้เพียง ล้านล้าน เท่านั้น!");


            int strLength = strInteger.Length;
            for (int i = 0; i < strInteger.Length; i++)
            {
                string number = strInteger.Substring(i, 1);
                if (number != "0")
                {
                    if (i == strLength - 1 && number == "1" && strLength != 1)
                    {
                        BahtText += "เอ็ด";
                        calling.Add("เอ็ด.mp3");
                    }
                    else if (i == strLength - 2 && number == "2" && strLength != 1)
                    {
                        BahtText += "ยี่";
                        calling.Add("20.mp3");
                    }
                    else if (i != strLength - 2 || number != "1")
                    {
                        BahtText += strThaiNumber[int.Parse(number)];
                        calling.Add(callNumber[int.Parse(number)]);
                    }

                    BahtText += strThaiPos[(strLength - i) - 1];
                    if (!(number=="2" && strLength==2))
                    calling.Add(callPos[(strLength - i) - 1]);
                }
            }


            return calling;
        }

        public void talkCallingQ(string pre,string qid,string sendto)
        {
          //  var pl = newPlaylist(pre + qid +" " + sendto);
            addPlaylist( path + "calling.mp3");
            addPlaylist( path + pre + ".mp3");
            talkNum(qid);
            addPlaylist( path + "sendto.mp3");
            talkNum(sendto);

            RunPlaylist();
           // playSound(ref pl);

            Console.WriteLine("windows media");
            //Console.WriteLine(wplayer.playState);



            // addPlaylist(ref pl, path + );
        }
        public void talkNum(string n)
        {
            var nn = readNum(n);

            //var pl=newPlaylist(n);
        
            foreach (var s in nn)
            {
                if (s != null)
                {
                    var pt = path + s;
                    //playlist.appendItem(wplayer.newMedia(pt));
                    addPlaylist( pt);
                }
              //  playSound(s);
            }
          
        }
        private WMPLib.IWMPPlaylist newPlaylist(string n)
        {
            return wplayer.newPlaylist(n, "");
        }

        private void addPlaylist(string pt)
        {
            AddToPlaylist(pt);
           // playlist.appendItem(wplayer.newMedia(pt));
        }

    }
}
