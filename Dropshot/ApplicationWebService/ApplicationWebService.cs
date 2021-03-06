﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IO;
using UberStrike.DataCenter.Common.Entities;
using UberStrike.Core.Serialization;
using UberStrike.Core.Models.Views;
using UberStrike.Core.Types;
using Cmune.Core.Models.Views;
using Cmune.DataCenter.Common.Entities;

namespace ApplicationWebService {
	[ServiceBehavior]
	class ApplicationWebService : IApplicationWebServiceContract {
		public byte[] AuthenticateApplication(byte[] data) {
			MemoryStream outputStream = new MemoryStream();
			AuthenticateApplicationView instance = new AuthenticateApplicationView() {
				CommServer = new PhotonView() {
					IP = "127.0.0.1",
					MinLatency = 1000,
					Name = "EU West",
					PhotonId = 743958298,
					Port = 80,
					Region = RegionType.EuWest,
					UsageType = PhotonUsageType.CommServer
				},
				EncryptionInitVector = "032847tw8ehufiiuhaer",
				EncryptionPassPhrase = "gldjjofsdsdj2i0ß9",
				GameServers = new List<PhotonView>(),
				IsEnabled = true,
				WarnPlayer = false
			};
			AuthenticateApplicationViewProxy.Serialize(outputStream, instance);

			return outputStream.ToArray();
		}

		public byte[] GetConfigurationData(byte[] data) {
			MemoryStream outputStream = new MemoryStream();

			ApplicationConfigurationView instance = new ApplicationConfigurationView() {
				MaxLevel = 10,
				XpRequiredPerLevel = new Dictionary<int, int>() {
					{1, 1000 },
					{2, 2000 },
					{3, 3000 },
					{4, 4000 },
					{5, 5000 },
					{6, 6000 },
					{7, 7000 },
					{8, 8000 },
					{9, 9000 },
					{10, 10000 }

				}
			};

			ApplicationConfigurationViewProxy.Serialize(outputStream, instance);

			return outputStream.ToArray();
		}

		public byte[] GetMaps(byte[] data) {
			MemoryStream outputStream = new MemoryStream();

			List<MapView> instance = new List<MapView>() {
				new MapView() {
					MapId = 0,
					DisplayName = "The Warehouse",
					Description = "Example Description",
					SceneName = "TheWarehouse",
					IsBlueBox = false,
					RecommendedItemId = -1,
					SupportedGameModes = 1,
					SupportedItemClass = 1,
					MaxPlayers = 32,
					Settings = new Dictionary<GameModeType, MapSettings>() {
						{GameModeType.TeamDeathMatch, new MapSettings() }
					}
				},
				new MapView() {
					MapId = 1,
					DisplayName = "Gideons Tower",
					Description = "Example Description",
					SceneName = "GideonsTower",
					IsBlueBox = false,
					RecommendedItemId = -1,
					SupportedGameModes = 1,
					SupportedItemClass = 1,
					MaxPlayers = 32,
					Settings = new Dictionary<GameModeType, MapSettings>() {
						{GameModeType.TeamDeathMatch, new MapSettings() }
					}
				},
				new MapView() {
					MapId = 1,
					DisplayName = "Temple of the Raven",
					Description = "Example Description",
					SceneName = "TempleOfTheRaven",
					IsBlueBox = false,
					RecommendedItemId = -1,
					SupportedGameModes = 1,
					SupportedItemClass = 1,
					MaxPlayers = 32,
					Settings = new Dictionary<GameModeType, MapSettings>() {
						{GameModeType.TeamDeathMatch, new MapSettings() }
					}
				},
				new MapView() {
					MapId = 1,
					DisplayName = "CuberStrike",
					Description = "Example Description",
					SceneName = "CuberStrike",
					IsBlueBox = false,
					RecommendedItemId = -1,
					SupportedGameModes = 1,
					SupportedItemClass = 1,
					MaxPlayers = 32,
					Settings = new Dictionary<GameModeType, MapSettings>() {
						{GameModeType.TeamDeathMatch, new MapSettings() }
					}
				},
				new MapView() {
					MapId = 1,
					DisplayName = "Fort Winter",
					Description = "Example Description",
					SceneName = "FortWinter",
					IsBlueBox = false,
					RecommendedItemId = -1,
					SupportedGameModes = 1,
					SupportedItemClass = 1,
					MaxPlayers = 32,
					Settings = new Dictionary<GameModeType, MapSettings>() {
						{GameModeType.TeamDeathMatch, new MapSettings() }
					}
				},
				new MapView() {
					MapId = 1,
					DisplayName = "CuberSpace",
					Description = "Example Description",
					SceneName = "CuberSpace",
					IsBlueBox = false,
					RecommendedItemId = -1,
					SupportedGameModes = 1,
					SupportedItemClass = 1,
					MaxPlayers = 32,
					Settings = new Dictionary<GameModeType, MapSettings>() {
						{GameModeType.TeamDeathMatch, new MapSettings() }
					}
				},
			};
			ListProxy<MapView>.Serialize(outputStream, instance, new ListProxy<MapView>.Serializer<MapView>(MapViewProxy.Serialize));

			return outputStream.ToArray();
		}
	}
}
