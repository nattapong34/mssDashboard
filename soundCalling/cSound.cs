using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace soundCalling
{
    public class cSound
    {
        WMPLib.WindowsMediaPlayer wplayer;
        string path = Environment.CurrentDirectory + @"\sound\";

        WMPLib.IWMPPlaylist pl;

        public cSound()
        {
            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
            pl = newPlaylist("Onqueue");
        }

        void wplayer_PlayStateChange(int NewState)
        {
           // wplayer.currentPlaylist.attributeCount();
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Console.WriteLine(wplayer.playState);
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
            addPlaylist(ref pl, path + "calling.mp3");
            addPlaylist(ref pl, path + pre + ".mp3");
            talkNum(ref pl, qid);
            addPlaylist(ref pl, path + "sendto.mp3");
            talkNum(ref pl, sendto);
            if (wplayer.playState != WMPPlayState.wmppsPlaying)
                 playSound(ref pl);

            Console.WriteLine("windows media");
            Console.WriteLine(wplayer.playState);

            // addPlaylist(ref pl, path + );
        }
        public void talkNum(ref WMPLib.IWMPPlaylist pl,string n)
        {
            var nn = readNum(n);

            //var pl=newPlaylist(n);
        
            foreach (var s in nn)
            {
                var pt = path + s;
                //playlist.appendItem(wplayer.newMedia(pt));
                addPlaylist(ref pl, pt);
              //  playSound(s);
            }
          
        }
        private WMPLib.IWMPPlaylist newPlaylist(string n)
        {
            return wplayer.newPlaylist(n, "");
        }

        private void addPlaylist(ref WMPLib.IWMPPlaylist playlist, string pt)
        {
            playlist.appendItem(wplayer.newMedia(pt));
        }
        
        private void playSound(ref WMPLib.IWMPPlaylist playlist)
        {
            wplayer.currentPlaylist = playlist;
            wplayer.controls.play();
        }
    }
}
