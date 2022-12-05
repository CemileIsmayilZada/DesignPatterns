using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern.Abstracts
{
    public abstract class Phone
    {

        public void TemplateMethod()
        {
            this.CallMember();
            this.TakePhoto();
            this.AccessInternet();
            this.PlayGame();
            this.PlayMusic();
        }
        public abstract void CallMember();
        public abstract void TakePhoto();

        public virtual void PlayGame()
        {
            Console.WriteLine("Play Game for this phone:-");

        }
        public virtual void AccessInternet()
        {
            Console.WriteLine("Access Internet for this phone: -");

        }
        public void PlayMusic()
        {
            Console.WriteLine("Music can play");
        }

    }
}
