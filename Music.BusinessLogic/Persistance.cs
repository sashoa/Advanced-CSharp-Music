using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Service;
using Music.BusinessLogic.Models;
using System.IO;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Music.Entities;
using Music.DataAccess;
using System.Diagnostics;

namespace Music.BusinessLogic
{
    public class Persistance
    {
        private static ServiceProvider sp = new ServiceProvider();
        public static string Export(IEnumerable<IArtist> artists)
        {
            EntityTranslator translator = new EntityTranslator(sp);
            var jsonService = translator.ModelToEntity(artists).GetJsonService();
            Debug.WriteLine(jsonService.GetJson());
            return jsonService.GetJson();
        }

        public static ObservableCollection<IArtist> Import(string data)
        {
            var obj = JsonConvert.DeserializeObject<DataFormat>(data);

            //var bands = obj.Bands as List<BandEntity>;
            //var musicians = obj.Musicians as List<MusicianEntity>;
            //var albums = obj.Albums as List<AlbumEntity>;
            //var musicianInBands = obj.MusicianInBands as List<MusicianInBandsEntity>;
            //var songs = obj.Songs as List<SongEntity>;

            sp.BandRepository = new Repository<BandEntity>(obj.Bands);
            sp.MusicianRepository = new Repository<MusicianEntity>(obj.Musicians);
            sp.AlbumRepository = new Repository<AlbumEntity>(obj.Albums);
            sp.MusicianInBandsRepository = new Repository<MusicianInBandsEntity>(obj.MusicianInBands);
            sp.SongRepository = new Repository<SongEntity>(obj.Songs);

            var bandService = sp.GetBandService();
            var musicianService = sp.GetMusicianService();
            var albumService = sp.GetAlbumService();
            var musicianInBandService = sp.GetMusicianInBandsService();
            var songService = sp.GetSongService();

            EntityTranslator translator = new EntityTranslator(sp);
            var artists = translator.EntityToModel();

            var allBands = bandService.GetAllBands();
            var allMusicians = musicianService.GetAllMusicians();
            Debug.WriteLine(allBands.Count());
            Debug.WriteLine(allMusicians.Count());
            Debug.WriteLine("sashe");
            Debug.WriteLine(artists.Count());

            return new ObservableCollection<IArtist>(artists);
        }
    }
}
