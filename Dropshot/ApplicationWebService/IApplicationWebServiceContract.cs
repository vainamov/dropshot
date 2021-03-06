﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ApplicationWebService {
	[ServiceContract]
	public interface IApplicationWebServiceContract {
		[OperationContract]
		byte[] AuthenticateApplication(byte[] data);

		[OperationContract]
		byte[] GetConfigurationData(byte[] data);

		[OperationContract]
		byte[] GetMaps(byte[] data);
	}
}
