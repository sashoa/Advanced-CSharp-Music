using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Model;
using Music.Data;

namespace Music.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BandRepository bandRepository = new BandRepository();
            MusicianRepository musicianRepository = new MusicianRepository();
            List<IArtist> artists = new List<IArtist>();

            bandRepository.Add(new Band("Metallica"));
            bandRepository.Add(new Band("band2"));
            bandRepository.Add(new Band("band3"));
            bandRepository.Add(new Band("band4"));

            musicianRepository.Add(new Musician("James Hetfield") { BandId = bandRepository.GetAll().SingleOrDefault(b => b.Id == 1).Id });

            Console.WriteLine(bandRepository.GetAll().Count());
            var jameses = musicianRepository.GetAll().Where(m => m.Name.Contains("James"));

            foreach (var band in bandRepository.GetAll())
            {
                Console.WriteLine(band.Name);
            }
            Band test = new Band("test band");
            Console.WriteLine(test.Name);
        }
    }
}
