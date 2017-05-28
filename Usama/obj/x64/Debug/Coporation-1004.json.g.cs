// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Coporation.json"
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
using Usama.Model;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Usama {
using __Coporati1__ = global::Usama.Coporation.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoAdd__ = global::Usama.Coporation.Input.Add;
using __CoSave__ = global::Usama.Coporation.Input.Save;
using __CoName__ = global::Usama.Coporation.Input.Name;
using __CoHtml__ = global::Usama.Coporation.Input.Html;
using __Coporati2__ = global::Usama.Coporation.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Usama.Coporation.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Coporati__ = global::Usama.Coporation;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Coporation_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Coporation : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Coporation() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Coporation(__CoSchema__ template) { Template = template; }
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
                InstanceType = typeof(__Coporati__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Usama/CoporationJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Coporati__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Coporati__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Coporati__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Coporati__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Save = Add<__TLong__>("Save$");
                Save.DefaultValue = 0L;
                Save.Editable = true;
                Save.SetCustomAccessors((_p_) => { return ((__Coporati__)_p_).__bf__Save__; }, (_p_, _v_) => { ((__Coporati__)_p_).__bf__Save__ = (System.Int64)_v_; }, false);
                Save.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Save() { App = (Coporation)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((Coporation)pup).Handle((Input.Save)input); });
                Add = Add<__TLong__>("Add$");
                Add.DefaultValue = 0L;
                Add.Editable = true;
                Add.SetCustomAccessors((_p_) => { return ((__Coporati__)_p_).__bf__Add__; }, (_p_, _v_) => { ((__Coporati__)_p_).__bf__Add__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Coporati__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ Save;
            public __TLong__ Add;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "Coporation.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "Coporation.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "Coporation.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "Coporation.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Save__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Save {
    #line 4 "Coporation.json"
        get {
        #line hidden
            return Template.Save.Getter(this); }
        #line 4 "Coporation.json"
        set {
        #line hidden
            Template.Save.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Add__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Add {
    #line 5 "Coporation.json"
        get {
        #line hidden
            return Template.Add.Getter(this); }
        #line 5 "Coporation.json"
        set {
        #line hidden
            Template.Add.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Coporati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Coporati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Save : Input<__Coporati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Add : Input<__Coporati__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
