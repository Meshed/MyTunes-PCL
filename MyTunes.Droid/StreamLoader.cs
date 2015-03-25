using System;
using MyTunes.Shared;
using Android.Content;

namespace MyTunes
{
	public class StreamLoader : IStreamLoader
	{
		private readonly Context context;

		public StreamLoader(Context context)
		{
			this.context = context;
		}

		public System.IO.Stream GetStreamForFilename (string fileName)
		{
			return context.Assets.Open (fileName);
		}
	}
}

