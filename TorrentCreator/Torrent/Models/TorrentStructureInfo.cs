using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentCreator.Torrent.Models
{
	public class TorrentStructureInfo
	{

		public int PieceLength { get; set; }

		public bool IsPrivate { get; set; }

		public string Name { get; set; }

		public List<byte> BencodeByteData { get; set; }

		public long TotalLength { get; set; }

		public List<TorrentFilePieceInfo> Pieces { get; set; }

		public List<byte> PiecesBytes { get; set; }

	}
}
