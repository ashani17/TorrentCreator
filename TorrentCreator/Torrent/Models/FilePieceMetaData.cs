using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentCreator.Torrent.Models
{
	public class FilePieceMetaData
	{
		public int StartPieceNumber { get; set; }

		public long FileSize { get; set; }

		public string Path { get; set; }

	}
}
