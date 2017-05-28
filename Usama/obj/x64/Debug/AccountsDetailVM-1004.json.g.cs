// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "AccountsDetailVM.json"
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

using __Accounts2__ = global::AccountsDetailVM.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __AcAddress__ = global::AccountsDetailVM.Input.Address;
using __AcCommissi__ = global::AccountsDetailVM.Input.Commission;
using __AcSalespri__ = global::AccountsDetailVM.Input.Salesprice;
using __AcDate__ = global::AccountsDetailVM.Input.Date;
using __AcHtml__ = global::AccountsDetailVM.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __AcSchema__ = global::AccountsDetailVM.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Accounts__ = global::AccountsDetailVM;
using __Accounts1__ = global::AccountsDetailVM.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AccountsDetailVM_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class AccountsDetailVM : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AcSchema__ DefaultTemplate = new __AcSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AccountsDetailVM() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AccountsDetailVM(__AcSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/Usama/AccountsList.html";
                Html.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date");
                Date.DefaultValue = "";
                Date.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                Salesprice = Add<__TLong__>("Salesprice");
                Salesprice.DefaultValue = 0L;
                Salesprice.SetCustomAccessors((_p_) => { return ((__Accounts__)_p_).__bf__Salesprice__; }, (_p_, _v_) => { ((__Accounts__)_p_).__bf__Salesprice__ = (System.Int64)_v_; }, false);
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
            public __TLong__ Salesprice;
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
    #line 2 "AccountsDetailVM.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "AccountsDetailVM.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 3 "AccountsDetailVM.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 3 "AccountsDetailVM.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Salesprice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Salesprice {
    #line 4 "AccountsDetailVM.json"
        get {
        #line hidden
            return Template.Salesprice.Getter(this); }
        #line 4 "AccountsDetailVM.json"
        set {
        #line hidden
            Template.Salesprice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 5 "AccountsDetailVM.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "AccountsDetailVM.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 6 "AccountsDetailVM.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 6 "AccountsDetailVM.json"
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
        public class Salesprice : Input<__Accounts__, __TLong__, long> {
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
#pragma warning restore 1591
#pragma warning restore 0108
