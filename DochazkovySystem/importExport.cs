using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DochazkovySystem
{
	class importExport
	{
		public string sConnectionString =
                String.Format("{0};{1}\"{2}\"{3}",
                @"Data Source=(LocalDB)\v11.0",
                 "AttachDbFilename=",
                  System.IO.Path.GetFullPath(@"..\..\dochazka.mdf"),
                  ";Integrated Security=True;Connect Timeout=30");

		public string DConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + System.IO.Path.GetFullPath(@"..\..\dochazka.mdf") + "";



	}
}
