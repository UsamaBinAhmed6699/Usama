// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CorporationVM.json"
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
using __CoHtml__ = global::Usama.CorporationVM.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoTrend__ = global::Usama.CorporationVM.Input.Trend;
using __CoaverageC__ = global::Usama.CorporationVM.Input.averageCommission;
using __CototalCom__ = global::Usama.CorporationVM.Input.totalCommission;
using __ConoOfHome__ = global::Usama.CorporationVM.Input.noOfHomes;
using __Cofranchis__ = global::Usama.CorporationVM.Input.franchiseNametoAdd;
using __CoAdd__ = global::Usama.CorporationVM.Input.Add;
using __CoSave__ = global::Usama.CorporationVM.Input.Save;
using __CoName__ = global::Usama.CorporationVM.Input.Name;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Corporat1__ = global::Usama.CorporationVM.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Usama.CorporationVM.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Usama.CorporationVM;
using __Corporat2__ = global::Usama.CorporationVM.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationVM_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationVM : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationVM() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationVM(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Usama/CoporationJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Save = Add<__TLong__>("Save$");
                Save.DefaultValue = 0L;
                Save.Editable = true;
                Save.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Save__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Save__ = (System.Int64)_v_; }, false);
                Save.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Save() { App = (CorporationVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationVM)pup).Handle((Input.Save)input); });
                Add = Add<__TLong__>("Add$");
                Add.DefaultValue = 0L;
                Add.Editable = true;
                Add.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Add__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Add__ = (System.Int64)_v_; }, false);
                franchiseNametoAdd = Add<__TString__>("franchiseNametoAdd$");
                franchiseNametoAdd.DefaultValue = "";
                franchiseNametoAdd.Editable = true;
                franchiseNametoAdd.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__franchiseNametoAdd__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__franchiseNametoAdd__ = (System.String)_v_; }, false);
                franchise = Add<__TArray__>("franchise");
                franchise.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__franchise__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__franchise__ = (__Arr__)_v_; }, false);
                noOfHomes = Add<__TLong__>("noOfHomes$");
                noOfHomes.DefaultValue = 0L;
                noOfHomes.Editable = true;
                noOfHomes.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__noOfHomes__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__noOfHomes__ = (System.Int64)_v_; }, false);
                noOfHomes.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.noOfHomes() { App = (CorporationVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationVM)pup).Handle((Input.noOfHomes)input); });
                totalCommission = Add<__TLong__>("totalCommission$");
                totalCommission.DefaultValue = 0L;
                totalCommission.Editable = true;
                totalCommission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__totalCommission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__totalCommission__ = (System.Int64)_v_; }, false);
                totalCommission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.totalCommission() { App = (CorporationVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationVM)pup).Handle((Input.totalCommission)input); });
                averageCommission = Add<__TLong__>("averageCommission$");
                averageCommission.DefaultValue = 0L;
                averageCommission.Editable = true;
                averageCommission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__averageCommission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__averageCommission__ = (System.Int64)_v_; }, false);
                averageCommission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.averageCommission() { App = (CorporationVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationVM)pup).Handle((Input.averageCommission)input); });
                Trend = Add<__TLong__>("Trend$");
                Trend.DefaultValue = 0L;
                Trend.Editable = true;
                Trend.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                Trend.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Trend() { App = (CorporationVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationVM)pup).Handle((Input.Trend)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ Save;
            public __TLong__ Add;
            public __TString__ franchiseNametoAdd;
            public __TArray__ franchise;
            public __TLong__ noOfHomes;
            public __TLong__ totalCommission;
            public __TLong__ averageCommission;
            public __TLong__ Trend;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CorporationVM.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CorporationVM.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "CorporationVM.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "CorporationVM.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Save__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Save {
    #line 4 "CorporationVM.json"
        get {
        #line hidden
            return Template.Save.Getter(this); }
        #line 4 "CorporationVM.json"
        set {
        #line hidden
            Template.Save.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Add__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Add {
    #line 5 "CorporationVM.json"
        get {
        #line hidden
            return Template.Add.Getter(this); }
        #line 5 "CorporationVM.json"
        set {
        #line hidden
            Template.Add.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__franchiseNametoAdd__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String franchiseNametoAdd {
    #line 6 "CorporationVM.json"
        get {
        #line hidden
            return Template.franchiseNametoAdd.Getter(this); }
        #line 6 "CorporationVM.json"
        set {
        #line hidden
            Template.franchiseNametoAdd.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__franchise__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ franchise {
    #line 7 "CorporationVM.json"
        get {
        #line hidden
            return Template.franchise.Getter(this); }
        #line 7 "CorporationVM.json"
        set {
        #line hidden
            Template.franchise.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__noOfHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 noOfHomes {
    #line 8 "CorporationVM.json"
        get {
        #line hidden
            return Template.noOfHomes.Getter(this); }
        #line 8 "CorporationVM.json"
        set {
        #line hidden
            Template.noOfHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__totalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 totalCommission {
    #line 9 "CorporationVM.json"
        get {
        #line hidden
            return Template.totalCommission.Getter(this); }
        #line 9 "CorporationVM.json"
        set {
        #line hidden
            Template.totalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__averageCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 averageCommission {
    #line 10 "CorporationVM.json"
        get {
        #line hidden
            return Template.averageCommission.Getter(this); }
        #line 10 "CorporationVM.json"
        set {
        #line hidden
            Template.averageCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 11 "CorporationVM.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 11 "CorporationVM.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Save : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Add : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class franchiseNametoAdd : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class noOfHomes : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class totalCommission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class averageCommission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
