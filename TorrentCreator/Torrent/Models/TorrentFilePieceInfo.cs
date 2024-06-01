using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentCreator.Torrent.Models
{
	public class TorrentFilePieceInfo
	{

		public long Length { get; set; }

		public string MdSum { get; set; }

		public List<string> Path { get; set; }

	}
}
