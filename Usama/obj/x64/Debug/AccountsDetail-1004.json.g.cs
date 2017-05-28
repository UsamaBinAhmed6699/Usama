// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "AccountsDetail.json"
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
using __Accounts2__ = global::Usama.AccountsDetail.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __AcAddress__ = global::Usama.AccountsDetail.Input.Address;
using __AcCommissi__ = global::Usama.AccountsDetail.Input.Commission;
using __AcSalepric__ = global::Usama.AccountsDetail.Input.Saleprice;
using __AcDate__ = global::Usama.AccountsDetail.Input.Date;
using __AcHtml__ = global::Usama.AccountsDetail.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __AcSchema__ = global::Usama.AccountsDetail.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Accounts__ = global::Usama.AccountsDetail;
using __Accounts1__ = global::Usama.AccountsDetail.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AccountsDetail_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class AccountsDetail : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AcSchema__ DefaultTemplate = new __AcSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AccountsDetail() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AccountsDetail(__AcSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __AcSchema__ Template { get { return (__AcSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Accounts__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Usama/AccountsList";
                Html.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date");
                Date.DefaultValue = "";
                Date.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                Saleprice = Add<__TLong__>("Saleprice");
                Saleprice.DefaultValue = 0L;
                Saleprice.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Saleprice__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Saleprice__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission");
                Commission.DefaultValue = 0L;
                Commission.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                Address = Add<__TString__>("Address");
                Address.DefaultValue = "";
                Address.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Address__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Accounts__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Date;
            public __TLong__ Saleprice;
            public __TLong__ Commission;
            public __TString__ Address;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "AccountsDetail.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "AccountsDetail.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 3 "AccountsDetail.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 3 "AccountsDetail.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Saleprice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Saleprice {
    #line 4 "AccountsDetail.json"
        get {
        #line hidden
            return Template.Saleprice.Getter(this); }
        #line 4 "AccountsDetail.json"
        set {
        #line hidden
            Template.Saleprice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 5 "AccountsDetail.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "AccountsDetail.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 6 "AccountsDetail.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 6 "AccountsDetail.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Accounts__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__Accounts__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Saleprice : Input<__Accounts__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Accounts__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__Accounts__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
