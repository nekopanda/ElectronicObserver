﻿using ElectronicObserver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Observer.kcsapi.api_req_hensei {

	public class change : APIBase {


		public override void OnRequestReceived( Dictionary<string, string> data ) {

			KCDatabase.Instance.Fleet.LoadFromRequest( APIName, data );
			
			base.OnRequestReceived( data );
		}

		public override string APIName {
			get { return "api_req_hensei/change"; }
		}
	}

}
