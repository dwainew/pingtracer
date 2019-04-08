﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingTracer
{
	public class Settings : SerializableObjectBase
	{
		public bool logTextOutputToFile = true;
		public bool delayMostRecentPing = true;
		public bool warnGraphNotLive = true;
		public List<HostSettings> hostHistory = new List<HostSettings>();
		public int cacheSize = 10000;
		public bool fastRefreshScrollingGraphs = true;
		public int graphScrollMultiplier = 1;
		public bool showDateOnGraphTimeline = true;
		public string customTimeStr;

		public bool Save()
		{
			lock (hostHistory)
			{
				return Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('/', '\\') + "/PingTracer/settings.cfg");
			}
		}
		public bool Load()
		{
			return Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('/', '\\') + "/PingTracer/settings.cfg");
		}
	}
	public class HostSettings
	{
		public string host;
		public string displayName = "";
		public int rate = 1;
		public bool pingsPerSecond = true;
		public bool doTraceRoute = true;
		public bool reverseDnsLookup = true;
		public bool drawServerNames = true;
		public bool drawLastPing = true;
		public bool drawAverage = true;
		public bool drawJitter = false;
		public bool drawMinMax = false;
		public bool drawPacketLoss = true;
		public int badThreshold = 100;
		public int worseThreshold = 200;

		public override bool Equals(object other)
		{
			if (other is HostSettings)
			{
				HostSettings o = (HostSettings)other;
				return host == o.host
					&& rate == o.rate
					&& pingsPerSecond == o.pingsPerSecond
					&& doTraceRoute == o.doTraceRoute
					&& reverseDnsLookup == o.reverseDnsLookup
					&& drawServerNames == o.drawServerNames
					&& drawMinMax == o.drawMinMax
					&& drawPacketLoss == o.drawPacketLoss
					&& badThreshold == o.badThreshold
					&& worseThreshold == o.worseThreshold;
			}
			return false;
		}
		public override int GetHashCode()
		{
			return host.GetHashCode() ^ rate.GetHashCode() ^ badThreshold.GetHashCode() ^ worseThreshold.GetHashCode();
		}
	}
}
