using System;
using System.Net;
using CsQuery;

namespace AnUtterlyUselesClassLibraryForOneFunction
{
    public class AnUtterlyUselessClassForOneFunction
    {
	    public string AnUtterlyUselessFunctionWithThirdPartyDependenciesToGetiOSGodsProfileImage(Int32 id)
	    {
		    using (var Client = new WebClient())
		    {
			    var Data = Client.DownloadString(string.Format("http://iosgods.com/user/{0}-", id));
			    var Dom = CQ.Create(Data);

			    return Dom["#profile_photo"].Attr("src");
		    }
	    }
    }
}
