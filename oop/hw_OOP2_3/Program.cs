using System;

namespace hw_OOP2_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPopSinger popSinger = new PopSinger("Michael", "Jackson");
            IRockSinger rockSinger = new RockSinger("Elvis", "Presley");
            ISinger singer = new Singer("Uzeyir", "Mehdizade");

            singer.RecordSong();
            popSinger.RecordSong();
            rockSinger.RecordSong();

            singer.Sing();
            popSinger.Sing();
            rockSinger.Sing();


            popSinger.GoMoonWalk();
            rockSinger.SwingGuitar();

        }
    }
}
