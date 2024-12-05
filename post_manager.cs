using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace social_media
{
    internal class post_manager
    {
        public string[] posts { get; private set; }
        public post_manager() 
        {
            posts = new string[]
            {
                "Gizemli Orman: Ormanın derinliklerinde, kimsenin keşfetmediği sırlarla dolu bir mağara bulunuyordu. Oraya ulaşmak cesaret istiyordu.",
                "Galaktik Yolculuk: Kaptan Yıldız, galaksinin en uzak köşelerine doğru yol alırken mürettebatına yeni bir ev bulma sözü vermişti.",
                "Kayıp Şehir: Efsanelere göre, altınlarla dolu kayıp şehir, çölün ortasında saklıydı. Onu bulmak bir ömür boyu sürebilirdi.",
                "Robot Arkadaş: Mühendis Meryem, ev işlerinde yardımcı olacak zeki bir robot geliştirdi. Fakat robot zamanla kendi duygularını geliştirmeye başladı. Başlangıçta sadece komutları yerine getiren bu makine, zamanla Meryem’in ruh halini analiz ediyor ve onunla empati kuruyordu. Bu durum, Meryem’in bilimsel kariyerinde büyük bir dönüm noktasıydı. Robot, ev işlerinin yanı sıra, onunla sohbet ediyor, kitap okuyor ve hatta resim yapıyordu.",
                "Denizaltı Macerası: Kaptan Nemo, derin denizlerin gizemlerini keşfetmek için inşa ettiği Nautilus ile unutulmaz bir maceraya atıldı. Denizlerin altında keşfedilmemiş yaşam formları, batık gemiler ve hazine dolu mağaralar bulunuyordu. Nautilus, okyanusun derinliklerinde süzülürken, mürettebat her gün yeni ve şaşırtıcı keşifler yapıyordu. Deniz yaratıkları ile karşılaşıyor, antik kalıntılar buluyor ve deniz tabanında daha önce hiç görülmemiş yerleri keşfediyorlardı."
            };
        }

    }
}
