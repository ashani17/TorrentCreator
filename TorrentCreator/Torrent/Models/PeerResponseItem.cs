using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentCreator.Torrent.Models
{
	public class PeerResponseItem
	{
		public string PeerId { get; set; }

		//peer's IP address either IPv6 (hexed) or IPv4 (dotted quad) or DNS name (string)
		public string PeerIp { get; set; }

		public int Port { get; set; }

		public string GetIp()
		{
			return $"{PeerIp}:{Port}";
		}

	}
}
