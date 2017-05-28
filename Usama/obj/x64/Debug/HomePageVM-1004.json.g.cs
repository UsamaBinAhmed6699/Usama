// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "HomePageVM.json"
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
using __HomePage1__ = global::Usama.HomePageVM.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __HoAddCorpo__ = global::Usama.HomePageVM.Input.AddCorporation;
using __HoName__ = global::Usama.HomePageVM.Input.Name;
using __HoHtml__ = global::Usama.HomePageVM.Input.Html;
using __HomePage2__ = global::Usama.HomePageVM.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __HoSchema__ = global::Usama.HomePageVM.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __HomePage__ = global::Usama.HomePageVM;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class HomePageVM_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class HomePageVM : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __HoSchema__ DefaultTemplate = new __HoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HomePageVM() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HomePageVM(__HoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __HoSchema__ Template { get { return (__HoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__HomePage__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Usama/HomePage.html";
                Html.SetCustomAccessors((_p_) => { return ((__HomePage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__HomePage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__HomePage__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__HomePage__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                AddCorporation = Add<__TLong__>("AddCorporation$");
                AddCorporation.DefaultValue = 0L;
                AddCorporation.Editable = true;
                AddCorporation.SetCustomAccessors((_p_) => { return ((__HomePage__)_p_).__bf__AddCorporation__; }, (_p_, _v_) => { ((__HomePage__)_p_).__bf__AddCorporation__ = (System.Int64)_v_; }, false);
                AddCorporation.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddCorporation() { App = (HomePageVM)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((HomePageVM)pup).Handle((Input.AddCorporation)input); });
                CorporationsList = Add<__TArray__>("CorporationsList");
                CorporationsList.SetCustomAccessors((_p_) => { return ((__HomePage__)_p_).__bf__CorporationsList__; }, (_p_, _v_) => { ((__HomePage__)_p_).__bf__CorporationsList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __HomePage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ AddCorporation;
            public __TArray__ CorporationsList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "HomePageVM.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "HomePageVM.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "HomePageVM.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "HomePageVM.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddCorporation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddCorporation {
    #line 4 "HomePageVM.json"
        get {
        #line hidden
            return Template.AddCorporation.Getter(this); }
        #line 4 "HomePageVM.json"
        set {
        #line hidden
            Template.AddCorporation.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__CorporationsList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ CorporationsList {
    #line 5 "HomePageVM.json"
        get {
        #line hidden
            return Template.CorporationsList.Getter(this); }
        #line 5 "HomePageVM.json"
        set {
        #line hidden
            Template.CorporationsList.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__HomePage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__HomePage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddCorporation : Input<__HomePage__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
