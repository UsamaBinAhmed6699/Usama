// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Franchise.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Usama {
using __Franchis2__ = global::Usama.Franchise.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrAddNew__ = global::Usama.Franchise.Input.AddNew;
using __FrRedirect__ = global::Usama.Franchise.Input.RedirectUrl;
using __FrFranchis1__ = global::Usama.Franchise.Input.FranchiseNo;
using __FrName__ = global::Usama.Franchise.Input.Name;
using __FrFranchis__ = global::Usama.Franchise.Input.FranchiseName;
using __FrHtml__ = global::Usama.Franchise.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::Usama.Franchise.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Usama.Franchise.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Usama.Franchise;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Franchise_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Franchise : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Franchise() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Franchise(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FranchiseName = Add<__TString__>("FranchiseName$");
                FranchiseName.DefaultValue = "";
                FranchiseName.Editable = true;
                FranchiseName.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                FranchiseNo = Add<__TLong__>("FranchiseNo");
                FranchiseNo.DefaultValue = 0L;
                FranchiseNo.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FranchiseNo__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FranchiseNo__ = (System.Int64)_v_; }, false);
                RedirectUrl = Add<__TString__>("RedirectUrl$");
                RedirectUrl.DefaultValue = "";
                RedirectUrl.Editable = true;
                RedirectUrl.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__RedirectUrl__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__RedirectUrl__ = (System.String)_v_; }, false);
                AddNew = Add<__TString__>("AddNew$");
                AddNew.DefaultValue = "";
                AddNew.Editable = true;
                AddNew.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AddNew__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AddNew__ = (System.String)_v_; }, false);
                AddNew.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.AddNew() { App = (Franchise)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((Franchise)pup).Handle((Input.AddNew)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ FranchiseName;
            public __TString__ Name;
            public __TLong__ FranchiseNo;
            public __TString__ RedirectUrl;
            public __TString__ AddNew;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "Franchise.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "Franchise.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiseName {
    #line 3 "Franchise.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 3 "Franchise.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "Franchise.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "Franchise.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__FranchiseNo__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 FranchiseNo {
    #line 5 "Franchise.json"
        get {
        #line hidden
            return Template.FranchiseNo.Getter(this); }
        #line 5 "Franchise.json"
        set {
        #line hidden
            Template.FranchiseNo.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__RedirectUrl__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String RedirectUrl {
    #line 6 "Franchise.json"
        get {
        #line hidden
            return Template.RedirectUrl.Getter(this); }
        #line 6 "Franchise.json"
        set {
        #line hidden
            Template.RedirectUrl.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__AddNew__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String AddNew {
    #line 7 "Franchise.json"
        get {
        #line hidden
            return Template.AddNew.Getter(this); }
        #line 7 "Franchise.json"
        set {
        #line hidden
            Template.AddNew.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiseName : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiseNo : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RedirectUrl : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNew : Input<__Franchis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
