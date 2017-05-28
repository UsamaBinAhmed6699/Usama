// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FranchiseDetailVM.json"
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
using __FfrCountry__ = global::Usama.FranchiseDetailVM.franchiseJson.Input.Country;
using __FrAccounts2__ = global::Usama.FranchiseDetailVM.AccountsJson.Input;
using __FAcStreet__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.Street;
using __FAcNumber__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.Number;
using __FAcZipCode__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.ZipCode;
using __FAcCity__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.City;
using __FAcCountry__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.Country;
using __FAcDate__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.Date;
using __FAcSalespri__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.Salesprice;
using __FrAccounts1__ = global::Usama.FranchiseDetailVM.AccountsJson.JsonByExample;
using __FAcCommissi__ = global::Usama.FranchiseDetailVM.AccountsJson.Input.Commission;
using __Franchis2__ = global::Usama.FranchiseDetailVM.Input;
using __FrHtml__ = global::Usama.FranchiseDetailVM.Input.Html;
using __FrSave__ = global::Usama.FranchiseDetailVM.Input.Save;
using __FrRegistor__ = global::Usama.FranchiseDetailVM.Input.Registor;
using __FrAddress__ = global::Usama.FranchiseDetailVM.Input.Address;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __FrAccounts__ = global::Usama.FranchiseDetailVM.AccountsJson;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FfrCity__ = global::Usama.FranchiseDetailVM.franchiseJson.Input.City;
using __Franchis__ = global::Usama.FranchiseDetailVM;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::Usama.FranchiseDetailVM.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FfrSchema__ = global::Usama.FranchiseDetailVM.franchiseJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __FAcSchema__ = global::Usama.FranchiseDetailVM.AccountsJson.JsonByExample.Schema;
using __Franchis1__ = global::Usama.FranchiseDetailVM.JsonByExample;
using __Frfranchis__ = global::Usama.FranchiseDetailVM.franchiseJson;
using __Frfranchis1__ = global::Usama.FranchiseDetailVM.franchiseJson.JsonByExample;
using __Frfranchis2__ = global::Usama.FranchiseDetailVM.franchiseJson.Input;
using __FfrName__ = global::Usama.FranchiseDetailVM.franchiseJson.Input.Name;
using __FfrStreet__ = global::Usama.FranchiseDetailVM.franchiseJson.Input.Street;
using __FfrNumber__ = global::Usama.FranchiseDetailVM.franchiseJson.Input.Number;
using __FfrZipCode__ = global::Usama.FranchiseDetailVM.franchiseJson.Input.ZipCode;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetailVM_json : s::TemplateAttribute {
    
    #line hidden
    public class franchise : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Accounts : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class FranchiseDetailVM : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailVM() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailVM(__FrSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/Usama/FranchiseBussines.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                franchise = Add<__FfrSchema__>("franchise", bind:"franchise");
                franchise.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__franchise__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__franchise__ = (__Frfranchis__)_v_; }, false);
                Save = Add<__TLong__>("Save$");
                Save.DefaultValue = 0L;
                Save.Editable = true;
                Save.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Save__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Save__ = (System.Int64)_v_; }, false);
                Save.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Save() { App = (FranchiseDetailVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailVM)pup).Handle((Input.Save)input); });
                Accounts = Add<__FAcSchema__>("Accounts", bind:"Accounts");
                Accounts.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Accounts__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Accounts__ = (__FrAccounts__)_v_; }, false);
                Registor = Add<__TLong__>("Registor$");
                Registor.DefaultValue = 0L;
                Registor.Editable = true;
                Registor.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Registor__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Registor__ = (System.Int64)_v_; }, false);
                Registor.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Registor() { App = (FranchiseDetailVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailVM)pup).Handle((Input.Registor)input); });
                AccountsList = Add<__TArray__>("AccountsList");
                AccountsList.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AccountsList__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AccountsList__ = (__Arr__)_v_; }, false);
                Address = Add<__TString__>("Address");
                Address.DefaultValue = "";
                Address.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Address__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __FfrSchema__ franchise;
            public __TLong__ Save;
            public __FAcSchema__ Accounts;
            public __TLong__ Registor;
            public __TArray__ AccountsList;
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
    #line 2 "FranchiseDetailVM.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FranchiseDetailVM.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Frfranchis__ __bf__franchise__;
    #line default
    #line hidden
    private System.Int64 __bf__Save__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Save {
    #line 13 "FranchiseDetailVM.json"
        get {
        #line hidden
            return Template.Save.Getter(this); }
        #line 13 "FranchiseDetailVM.json"
        set {
        #line hidden
            Template.Save.Setter(this, value); } }
        #line default
    #line hidden
    private __FrAccounts__ __bf__Accounts__;
    #line default
    #line hidden
    private System.Int64 __bf__Registor__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Registor {
    #line 26 "FranchiseDetailVM.json"
        get {
        #line hidden
            return Template.Registor.Getter(this); }
        #line 26 "FranchiseDetailVM.json"
        set {
        #line hidden
            Template.Registor.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__AccountsList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ AccountsList {
    #line 27 "FranchiseDetailVM.json"
        get {
        #line hidden
            return Template.AccountsList.Getter(this); }
        #line 27 "FranchiseDetailVM.json"
        set {
        #line hidden
            Template.AccountsList.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 28 "FranchiseDetailVM.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 28 "FranchiseDetailVM.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class franchiseJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FfrSchema__ DefaultTemplate = new __FfrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public franchiseJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public franchiseJson(__FfrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FfrSchema__ Template { get { return (__FfrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__Frfranchis__);
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    Number = Add<__TString__>("Number$");
                    Number.DefaultValue = "";
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                    ZipCode = Add<__TString__>("ZipCode$");
                    ZipCode.DefaultValue = "";
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __Frfranchis__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ Street;
                public __TString__ Number;
                public __TString__ ZipCode;
                public __TString__ City;
                public __TString__ Country;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 5 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 5 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Street {
        #line 6 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 6 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Number {
        #line 7 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 7 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipCode {
        #line 8 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 8 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 9 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 9 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 10 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 10 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class AccountsJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FAcSchema__ DefaultTemplate = new __FAcSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AccountsJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AccountsJson(__FAcSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FAcSchema__ Template { get { return (__FAcSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrAccounts__);
                    Properties.ClearExposed();
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    Number = Add<__TString__>("Number$");
                    Number.DefaultValue = "";
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                    ZipCode = Add<__TString__>("ZipCode$");
                    ZipCode.DefaultValue = "";
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__City__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                    Date = Add<__TString__>("Date$");
                    Date.DefaultValue = "";
                    Date.Editable = true;
                    Date.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                    Salesprice = Add<__TLong__>("Salesprice$");
                    Salesprice.DefaultValue = 0L;
                    Salesprice.Editable = true;
                    Salesprice.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__Salesprice__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__Salesprice__ = (System.Int64)_v_; }, false);
                    Commission = Add<__TLong__>("Commission$");
                    Commission.DefaultValue = 0L;
                    Commission.Editable = true;
                    Commission.SetCustomAccessors((_p_) => { return ((__FrAccounts__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__FrAccounts__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __FrAccounts__(this) { Parent = parent }; }
                public __TString__ Street;
                public __TString__ Number;
                public __TString__ ZipCode;
                public __TString__ City;
                public __TString__ Country;
                public __TString__ Date;
                public __TLong__ Salesprice;
                public __TLong__ Commission;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Street {
        #line 16 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 16 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Number {
        #line 17 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 17 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipCode {
        #line 18 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 18 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 19 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 19 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 20 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 20 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Date__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Date {
        #line 21 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Date.Getter(this); }
            #line 21 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Date.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Salesprice__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Salesprice {
        #line 22 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Salesprice.Getter(this); }
            #line 22 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Salesprice.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Commission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Commission {
        #line 23 "FranchiseDetailVM.json"
            get {
            #line hidden
                return Template.Commission.Getter(this); }
            #line 23 "FranchiseDetailVM.json"
            set {
            #line hidden
                Template.Commission.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__FrAccounts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__FrAccounts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__FrAccounts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__FrAccounts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__FrAccounts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Date : Input<__FrAccounts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Salesprice : Input<__FrAccounts__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Commission : Input<__FrAccounts__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Save : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Registor : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__Franchis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
