﻿using Akavache;
using Espera.Core.Settings;

namespace Espera.View
{
    public class ViewSettings : Settings
    {
        public ViewSettings(IBlobCache blobCache)
            : base("__ViewSettings__", blobCache)
        { }

        public string AccentColor
        {
            get { return this.GetOrCreate("Blue"); }
            set { this.SetOrCreate(value); }
        }

        public bool GoFullScreenOnLock
        {
            get { return this.GetOrCreate(true); }
            set { this.SetOrCreate(value); }
        }

        public int LocalAlbumColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int LocalArtistColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int LocalDurationColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int LocalGenreColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int LocalPathColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int LocalTitleColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public bool LockWindow
        {
            get { return this.GetOrCreate(true); }
            set { this.SetOrCreate(value); }
        }

        public int PlaylistAlbumColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int PlaylistArtistColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int PlaylistDurationColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int PlaylistGenreColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public string PlaylistHeight
        {
            get { return this.GetOrCreate("*"); }
            set { this.SetOrCreate(value); }
        }

        public int PlaylistSourceColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int PlaylistTitleColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public double Scaling
        {
            get { return this.GetOrCreate(1.0); }
            set { this.SetOrCreate(value); }
        }

        public string SongSourceHeight
        {
            get { return this.GetOrCreate("*"); }
            set { this.SetOrCreate(value); }
        }

        public int YoutubeDurationColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int YoutubeLinkColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int YoutubeRatingColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int YoutubeTitleColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }

        public int YoutubeViewsColumnWidth
        {
            get { return this.GetOrCreate(100); }
            set { this.SetOrCreate(value); }
        }
    }
}