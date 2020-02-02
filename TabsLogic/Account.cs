using System;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UtopiaLib;

namespace UtopiaUtilities
{
	public partial class MainForm {
		void Btn_getMyPubkeyClick(object sender, EventArgs e)
		{
			if (!isClientConnected()) return;
			
			JObject result = client.getOwnContact();
			//response2log(result);
			loger.print("your pubkey: " + result["pk"]);
		}
		
		void Btn_getMyPubkeyCLPClick(object sender, EventArgs e)
		{
			if (!isClientConnected()) return;
			
			JObject result = client.getOwnContact();
			string pubkey = result["pk"].ToString();
			loger.print("your public key is copied to the clipboard");
			Clipboard.SetText(pubkey);
		}
	}
}
