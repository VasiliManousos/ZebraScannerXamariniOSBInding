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
    [Register("FirmwareUpdateEvent", true)]
    public unsafe partial class FirmwareUpdateEvent : NSObject
    {

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        static readonly IntPtr class_ptr = Class.GetHandle("FirmwareUpdateEvent");

        public override IntPtr ClassHandle { get { return class_ptr; } }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Export("init")]
        public FirmwareUpdateEvent() : base(NSObjectFlag.Empty)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
            if (IsDirectBinding)
            {
                InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
            }
            else
            {
                InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected FirmwareUpdateEvent(NSObjectFlag t) : base(t)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal FirmwareUpdateEvent(IntPtr handle) : base(handle)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
        }

        [Export("initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public FirmwareUpdateEvent(ScannerInfo _scannerInfo, int _maxRecords, int _swComponent, int _currentRecord, FirmwareUpdateResult _status)
            : base(NSObjectFlag.Empty)
        {
            if (_scannerInfo == null)
                throw new ArgumentNullException("_scannerInfo");
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
            if (IsDirectBinding)
            {
                InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend_IntPtr_int_int_int_UInt32(this.Handle, Selector.GetHandle("initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:"), _scannerInfo.Handle, _maxRecords, _swComponent, _currentRecord, (UInt32)_status), "initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:");
            }
            else
            {
                InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper_IntPtr_int_int_int_UInt32(this.SuperHandle, Selector.GetHandle("initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:"), _scannerInfo.Handle, _maxRecords, _swComponent, _currentRecord, (UInt32)_status), "initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:");
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int CurrentRecord
        {
            [Export("currentRecord")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("currentRecord"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("currentRecord"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int MaxRecords
        {
            [Export("maxRecords")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("maxRecords"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("maxRecords"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual ScannerInfo ScannerInfo
        {
            [Export("scannerInfo", ArgumentSemantic.Retain)]
            get
            {
                ScannerInfo ret;
                if (IsDirectBinding)
                {
                    ret = Runtime.GetNSObject<ScannerInfo>(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("scannerInfo")));
                }
                else
                {
                    ret = Runtime.GetNSObject<ScannerInfo>(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("scannerInfo")));
                }
                return ret;
            }

            [Export("setScannerInfo:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                if (IsDirectBinding)
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setScannerInfo:"), value.Handle);
                }
                else
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setScannerInfo:"), value.Handle);
                }
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int Size
        {
            [Export("size")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("size"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("size"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual FirmwareUpdateResult Status
        {
            [Export("status")]
            get
            {
                if (IsDirectBinding)
                {
                    return (FirmwareUpdateResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend(this.Handle, Selector.GetHandle("status"));
                }
                else
                {
                    return (FirmwareUpdateResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("status"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int SwComponent
        {
            [Export("swComponent")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("swComponent"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("swComponent"));
                }
            }

        }

    } /* class FirmwareUpdateEvent */
}
