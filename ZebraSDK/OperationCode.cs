//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace Zebra {
	public enum OperationCode : int {
		DevicePullTrigger = 2011,
		DeviceReleaseTrigger = 2012,
		DeviceScanDisable = 2013,
		DeviceScanEnable = 2014,
		DeviceCaptureImage = 3000,
		DeviceCaptureBarcode = 3500,
		DeviceCaptureVideo = 4000,
		RsmAttrGetall = 5000,
		RsmAttrGet = 5001,
		RsmAttrGetOffset = 5003,
		RsmAttrSet = 5004,
		RsmAttrStore = 5005,
		SetAction = 6000,
		StartNewFirmware = 5014,
		UpdateFirmware = 5016,
		UpdateFirmwareFromPlugin = 5017,
		DeviceSetParameterDefaults = 2015,
		DeviceSetParameters = 2016,
		DeviceSetParameterPersistance = 2017,
		DeviceAbortUpdateFirmware = 2001,
		DeviceAbortMacropdf = 2000,
		DeviceAimOff = 2002,
		DeviceAimOn = 2003,
		DeviceEnterLowPowerMode = 2004,
		DeviceFlushMacropdf = 2005,
		DeviceGetParameters = 2007,
		DeviceGetScannerCapabilities = 2008,
		DeviceLedOff = 2009,
		DeviceLedOn = 2010,
		DeviceBeepControl = 2018,
		RebootScanner = 2019,
		DeviceAbortImageXfer = 3001,
		RsmAttrGetnext = 5002,
		GetDeviceTopology = 5006,
		RefreshTopology = 5007,
		GetDeviceTopologyEx = 5008,
		RsmGetPcktsize = 5011,
		UpdateAttribMetaFile = 5015,
		DeviceVibrationFeedback = 2020,
		ErrorOpcode = -1,
	}
}
