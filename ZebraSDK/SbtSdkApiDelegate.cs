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

namespace Zebra
{
    [Protocol(Name = "SbtSdkApiDelegate", WrapperType = typeof(SbtSdkApiDelegateWrapper))]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventScannerAppeared", Selector = "sbtEventScannerAppeared:", ParameterType = new Type[] { typeof(Zebra.ScannerInfo) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventScannerDisappeared", Selector = "sbtEventScannerDisappeared:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventCommunicationSessionEstablished", Selector = "sbtEventCommunicationSessionEstablished:", ParameterType = new Type[] { typeof(Zebra.ScannerInfo) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventCommunicationSessionTerminated", Selector = "sbtEventCommunicationSessionTerminated:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventBarcode", Selector = "sbtEventBarcode:barcodeType:fromScanner:", ParameterType = new Type[] { typeof(string), typeof(Zebra.BarcodeType), typeof(int) }, ParameterByRef = new bool[] { false, false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventBarcodeData", Selector = "sbtEventBarcodeData:barcodeType:fromScanner:", ParameterType = new Type[] { typeof(NSData), typeof(Zebra.BarcodeType), typeof(int) }, ParameterByRef = new bool[] { false, false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventFirmwareUpdate", Selector = "sbtEventFirmwareUpdate:", ParameterType = new Type[] { typeof(Zebra.FirmwareUpdateEvent) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventImage", Selector = "sbtEventImage:fromScanner:", ParameterType = new Type[] { typeof(NSData), typeof(int) }, ParameterByRef = new bool[] { false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventVideo", Selector = "sbtEventVideo:fromScanner:", ParameterType = new Type[] { typeof(NSData), typeof(int) }, ParameterByRef = new bool[] { false, false })]
    public interface ISbtSdkApiDelegate : INativeObject, IDisposable
    {
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventScannerAppeared:")]
        [Preserve(Conditional = true)]
        void EventScannerAppeared(ScannerInfo availableScanner);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventScannerDisappeared:")]
        [Preserve(Conditional = true)]
        void EventScannerDisappeared(int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventCommunicationSessionEstablished:")]
        [Preserve(Conditional = true)]
        void EventCommunicationSessionEstablished(ScannerInfo activeScanner);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventCommunicationSessionTerminated:")]
        [Preserve(Conditional = true)]
        void EventCommunicationSessionTerminated(int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventBarcode:barcodeType:fromScanner:")]
        [Preserve(Conditional = true)]
        void EventBarcode(string barcodeData, BarcodeType barcodeType, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]
        [Preserve(Conditional = true)]
        void EventBarcodeData(NSData barcodeData, BarcodeType barcodeType, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventFirmwareUpdate:")]
        [Preserve(Conditional = true)]
        void EventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventImage:fromScanner:")]
        [Preserve(Conditional = true)]
        void EventImage(NSData imageData, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventVideo:fromScanner:")]
        [Preserve(Conditional = true)]
        void EventVideo(NSData videoFrame, int scannerID);

    }

    internal sealed class SbtSdkApiDelegateWrapper : BaseWrapper, ISbtSdkApiDelegate
    {
        [Preserve(Conditional = true)]
        public SbtSdkApiDelegateWrapper(IntPtr handle, bool owns)
            : base(handle, owns)
        {
        }

        [Export("sbtEventScannerAppeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventScannerAppeared(ScannerInfo availableScanner)
        {
            if (availableScanner == null)
                throw new ArgumentNullException("availableScanner");
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtEventScannerAppeared:"), availableScanner.Handle);
        }

        [Export("sbtEventScannerDisappeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventScannerDisappeared(int scannerID)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("sbtEventScannerDisappeared:"), scannerID);
        }

        [Export("sbtEventCommunicationSessionEstablished:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventCommunicationSessionEstablished(ScannerInfo activeScanner)
        {
            if (activeScanner == null)
                throw new ArgumentNullException("activeScanner");
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtEventCommunicationSessionEstablished:"), activeScanner.Handle);
        }

        [Export("sbtEventCommunicationSessionTerminated:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventCommunicationSessionTerminated(int scannerID)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("sbtEventCommunicationSessionTerminated:"), scannerID);
        }

        [Export("sbtEventBarcode:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventBarcode(string barcodeData, BarcodeType barcodeType, int scannerID)
        {
            if (barcodeData == null)
                throw new ArgumentNullException("barcodeData");
            var nsbarcodeData = NSString.CreateNative(barcodeData);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr_int_int(this.Handle, Selector.GetHandle("sbtEventBarcode:barcodeType:fromScanner:"), nsbarcodeData, (int)barcodeType, scannerID);
            NSString.ReleaseNative(nsbarcodeData);

        }

        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventBarcodeData(NSData barcodeData, BarcodeType barcodeType, int scannerID)
        {
            if (barcodeData == null)
                throw new ArgumentNullException("barcodeData");
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr_int_int(this.Handle, Selector.GetHandle("sbtEventBarcodeData:barcodeType:fromScanner:"), barcodeData.Handle, (int)barcodeType, scannerID);
        }

        [Export("sbtEventFirmwareUpdate:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj)
        {
            if (fwUpdateEventObj == null)
                throw new ArgumentNullException("fwUpdateEventObj");
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtEventFirmwareUpdate:"), fwUpdateEventObj.Handle);
        }

        [Export("sbtEventImage:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventImage(NSData imageData, int scannerID)
        {
            if (imageData == null)
                throw new ArgumentNullException("imageData");
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr_int(this.Handle, Selector.GetHandle("sbtEventImage:fromScanner:"), imageData.Handle, scannerID);
        }

        [Export("sbtEventVideo:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void EventVideo(NSData videoFrame, int scannerID)
        {
            if (videoFrame == null)
                throw new ArgumentNullException("videoFrame");
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr_int(this.Handle, Selector.GetHandle("sbtEventVideo:fromScanner:"), videoFrame.Handle, scannerID);
        }

    }
}
namespace Zebra
{
    [Protocol()]
    [Register("SbtSdkApiDelegate", false)]
    [Model]
    public unsafe abstract partial class SbtSdkApiDelegate : NSObject, ISbtSdkApiDelegate
    {

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Export("init")]
        protected SbtSdkApiDelegate() : base(NSObjectFlag.Empty)
        {
            IsDirectBinding = false;
            InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected SbtSdkApiDelegate(NSObjectFlag t) : base(t)
        {
            IsDirectBinding = false;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal SbtSdkApiDelegate(IntPtr handle) : base(handle)
        {
            IsDirectBinding = false;
        }

        [Export("sbtEventBarcode:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventBarcode(string barcodeData, BarcodeType barcodeType, int scannerID);
        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventBarcodeData(NSData barcodeData, BarcodeType barcodeType, int scannerID);
        [Export("sbtEventCommunicationSessionEstablished:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventCommunicationSessionEstablished(ScannerInfo activeScanner);
        [Export("sbtEventCommunicationSessionTerminated:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventCommunicationSessionTerminated(int scannerID);
        [Export("sbtEventFirmwareUpdate:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj);
        [Export("sbtEventImage:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventImage(NSData imageData, int scannerID);
        [Export("sbtEventScannerAppeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventScannerAppeared(ScannerInfo availableScanner);
        [Export("sbtEventScannerDisappeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventScannerDisappeared(int scannerID);
        [Export("sbtEventVideo:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void EventVideo(NSData videoFrame, int scannerID);
    } /* class SbtSdkApiDelegate */
}
