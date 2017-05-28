// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FranchiseVM.json"
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
using __Franchis2__ = global::Usama.FranchiseVM.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __Frtrend__ = global::Usama.FranchiseVM.Input.trend;
using __FraverageC__ = global::Usama.FranchiseVM.Input.averageCommission;
using __FrtotalCom__ = global::Usama.FranchiseVM.Input.totalCommission;
using __FrnoOfHome__ = global::Usama.FranchiseVM.Input.noOfHomes;
using __FrName__ = global::Usama.FranchiseVM.Input.Name;
using __FrId__ = global::Usama.FranchiseVM.Input.Id;
using __FrHtml__ = global::Usama.FranchiseVM.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::Usama.FranchiseVM.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Usama.FranchiseVM.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Usama.FranchiseVM;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseVM_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseVM : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseVM() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseVM(__FrSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/Usama/FranchiseJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Id = Add<__TString__>("Id", bind:"Id");
                Id.DefaultValue = "";
                Id.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                noOfHomes = Add<__TLong__>("noOfHomes");
                noOfHomes.DefaultValue = 0L;
                noOfHomes.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__noOfHomes__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__noOfHomes__ = (System.Int64)_v_; }, false);
                totalCommission = Add<__TLong__>("totalCommission");
                totalCommission.DefaultValue = 0L;
                totalCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__totalCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__totalCommission__ = (System.Int64)_v_; }, false);
                averageCommission = Add<__TDecimal__>("averageCommission");
                averageCommission.DefaultValue = 0.0m;
                averageCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__averageCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__averageCommission__ = (System.Decimal)_v_; }, false);
                trend = Add<__TLong__>("trend");
                trend.DefaultValue = 0L;
                trend.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__trend__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__trend__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Id;
            public __TString__ Name;
            public __TLong__ noOfHomes;
            public __TLong__ totalCommission;
            public __TDecimal__ averageCommission;
            public __TLong__ trend;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "FranchiseVM.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FranchiseVM.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Id__;
    #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "FranchiseVM.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "FranchiseVM.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__noOfHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 noOfHomes {
    #line 5 "FranchiseVM.json"
        get {
        #line hidden
            return Template.noOfHomes.Getter(this); }
        #line 5 "FranchiseVM.json"
        set {
        #line hidden
            Template.noOfHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__totalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 totalCommission {
    #line 6 "FranchiseVM.json"
        get {
        #line hidden
            return Template.totalCommission.Getter(this); }
        #line 6 "FranchiseVM.json"
        set {
        #line hidden
            Template.totalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Decimal __bf__averageCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal averageCommission {
    #line 7 "FranchiseVM.json"
        get {
        #line hidden
            return Template.averageCommission.Getter(this); }
        #line 7 "FranchiseVM.json"
        set {
        #line hidden
            Template.averageCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 trend {
    #line 8 "FranchiseVM.json"
        get {
        #line hidden
            return Template.trend.Getter(this); }
        #line 8 "FranchiseVM.json"
        set {
        #line hidden
            Template.trend.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Id : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class noOfHomes : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class totalCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class averageCommission : Input<__Franchis__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class trend : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
