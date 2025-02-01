FeatureScript 2543;
import(path : "onshape/std/geometry.fs", version : "2543.0");

annotation { "Default Units" : ["cubicMillimeter", "degree", "degreePerSecond", "footPoundForce", "kilogram", "millimeter", "millimeterPerSecondSquared", "newton", "newtonMeter", "pascal", "second", "squareMillimeter"] }
export function main()
{
    return build({});
}

export function build()
{
    return buildPrivate({});
}

export function build(configuration is map)
{
    return buildPrivate(configuration);
}

const buildPrivate = definePartStudio(function(context is Context, configuration is map, lookup is function)
    precondition
    {
    }
    {
        const id is Id = newId();
        annotation { 'unused' : true }
        var features = {};
        features.FljVSeiGj8mmgBx_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFljVSeiGj8mmgBx_0 = { "4hm38ZzH1CYj" : [0.0, 0.0, 1.0, 0.0, 0.009000000000000001, -1.0] };
                    {
                    }
                    var jwIBRYdqlKBhvw_query;
                    jwIBRYdqlKBhvw_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "FljVSeiGj8mmgBx_0", { "sketchPlane" : qUnion([jwIBRYdqlKBhvw_query]), "disableImprinting" : false });
                    skCircle(sketch, "4hm38ZzH1CYj", { "construction" : false, "index" : "1" });
                    {
                        var xrjfHnOgeBjuVo_query;
                        xrjfHnOgeBjuVo_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "4hm38ZzH1CYj.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "localFirst" : "4hm38ZzH1CYj.center", "externalSecond" : qUnion([xrjfHnOgeBjuVo_query]) });
                    }
                    {
                        skConstraint(sketch, "paW7qMqJghOh", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "localFirst" : "4hm38ZzH1CYj", "length" : { 'value' : try(18 * millimeter), 'expression' : "18 mm" }.value, "labelRatio" : 0.3585849676566677, "labelAngle" : -0.42271689675218826 * radian });
                    }
                    skSetInitialGuess(sketch, initialGuessFljVSeiGj8mmgBx_0);
                    skSolve(sketch);
                }
            };
        try(features.FljVSeiGj8mmgBx_0(id));
        features.FzHHI0ijqn11CFs_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var nuasTZdZIpeFDI_query;
                    nuasTZdZIpeFDI_query = qSketchRegion(id + "FljVSeiGj8mmgBx_0", true);
                    annotation { "Feature Name" : "Thicken 1" }
                    thicken(context, id + "FzHHI0ijqn11CFs_0", { "operationType" : NewBodyOperationType.NEW, "entities" : qUnion([nuasTZdZIpeFDI_query]), "midplane" : false, "thickness1" : { 'value' : try(15 * millimeter), 'expression' : "15 mm" }.value, "oppositeDirection" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "keepTools" : false, "defaultScope" : false, "booleanScope" : qUnion([]) });
                }
            };
        try(features.FzHHI0ijqn11CFs_0(id));
        features.FqQRAUkb4iWf3ju_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFqQRAUkb4iWf3ju_1 = { "9rJN8tN4y2GM" : [0.0, 4.9141538558609585E-19, 1.0, 0.0, 0.009173435814456768, -1.0], "1KFsrvR9LbT4" : [0.0, 0.009173435814456768, 0.0, -1.0, 0.0034324259566051794, 8.922801548906146E-4], "XYU0VKRP4wky.0.1.0" : [-0.0023742598978069656, 0.008860858568988886, 0.25881904510252074, -0.9659258262890683, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.2.0" : [-0.004586717907228383, 0.007944428455305554, 0.49999999999999994, -0.8660254037844387, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.3.0" : [-0.00648659867118192, 0.0064865986711819205, 0.7071067811865475, -0.7071067811865476, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.4.0" : [-0.007944428455305554, 0.004586717907228385, 0.8660254037844386, -0.5000000000000001, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.5.0" : [-0.008860858568988886, 0.0023742598978069656, 0.9659258262890683, -0.25881904510252074, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.6.0" : [-0.009173435814456768, 5.6171094036790875E-19, 1.0, -6.123233995736766E-17, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.7.0" : [-0.008860858568988886, -0.0023742598978069643, 0.9659258262890683, 0.25881904510252063, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.8.0" : [-0.007944428455305554, -0.004586717907228382, 0.8660254037844388, 0.49999999999999983, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.9.0" : [-0.0064865986711819205, -0.00648659867118192, 0.7071067811865476, 0.7071067811865475, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.10.0" : [-0.004586717907228383, -0.007944428455305554, 0.49999999999999994, 0.8660254037844387, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.11.0" : [-0.0023742598978069678, -0.008860858568988885, 0.258819045102521, 0.9659258262890682, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.12.0" : [-1.1234218807358175E-18, -0.009173435814456768, 1.2246467991473532E-16, 1.0, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.13.0" : [0.002374259897806966, -0.008860858568988886, -0.2588190451025208, 0.9659258262890683, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.14.0" : [0.0045867179072283815, -0.007944428455305555, -0.4999999999999997, 0.8660254037844388, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.15.0" : [0.006486598671181917, -0.006486598671181924, -0.7071067811865471, 0.7071067811865479, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.16.0" : [0.007944428455305552, -0.0045867179072283885, -0.8660254037844384, 0.5000000000000004, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.17.0" : [0.008860858568988886, -0.0023742598978069643, -0.9659258262890683, 0.25881904510252063, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.18.0" : [0.009173435814456768, -1.685132821103726E-18, -1.0, 1.8369701987210297E-16, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.19.0" : [0.008860858568988886, 0.0023742598978069612, -0.9659258262890684, -0.2588190451025203, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.20.0" : [0.007944428455305554, 0.004586717907228385, -0.8660254037844386, -0.5000000000000001, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.21.0" : [0.006486598671181922, 0.006486598671181919, -0.7071067811865477, -0.7071067811865474, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.22.0" : [0.0045867179072283885, 0.007944428455305552, -0.5000000000000004, -0.8660254037844384, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.0.23.0" : [0.002374259897806973, 0.008860858568988885, -0.25881904510252157, -0.9659258262890681, 0.003432425956605179, 8.922801548906145E-4], "XYU0VKRP4wky.center" : [0.0, 0.0], "1KFsrvR9LbT4.centerSnap0" : [1.5707963267948966] };
                    {
                    }
                    var cHUoUAJnDjBrvt_query;
                    cHUoUAJnDjBrvt_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5R0A1M2R1S8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FljVSeiGj8mmgBx_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$4hm38ZzH1CYjR7R8R9RaRbCeA1S-f.7$imprintReS7$IMPRINTD1R7C9S4$FACER9RaRbR14ReR15R7R1cR9RaS7$isStartTRbCeA1S11.9$FzHHI0ijqn11CFs_0opThickenReS8$CAP_FACE",id);
                    annotation { "Feature Name" : "Sketch 2" }
                    var sketch = newSketch(context, id + "FqQRAUkb4iWf3ju_1", { "sketchPlane" : qUnion([cHUoUAJnDjBrvt_query]), "disableImprinting" : false });
                    skCircle(sketch, "9rJN8tN4y2GM", { "construction" : true, "index" : "1" });
                    skEllipse(sketch, "1KFsrvR9LbT4", { "construction" : false, "index" : "1" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.1.0", { "construction" : false, "index" : "2" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.2.0", { "construction" : false, "index" : "3" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.3.0", { "construction" : false, "index" : "4" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.4.0", { "construction" : false, "index" : "5" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.5.0", { "construction" : false, "index" : "6" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.6.0", { "construction" : false, "index" : "7" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.7.0", { "construction" : false, "index" : "8" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.8.0", { "construction" : false, "index" : "9" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.9.0", { "construction" : false, "index" : "10" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.10.0", { "construction" : false, "index" : "11" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.11.0", { "construction" : false, "index" : "12" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.12.0", { "construction" : false, "index" : "13" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.13.0", { "construction" : false, "index" : "14" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.14.0", { "construction" : false, "index" : "15" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.15.0", { "construction" : false, "index" : "16" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.16.0", { "construction" : false, "index" : "17" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.17.0", { "construction" : false, "index" : "18" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.18.0", { "construction" : false, "index" : "19" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.19.0", { "construction" : false, "index" : "20" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.20.0", { "construction" : false, "index" : "21" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.21.0", { "construction" : false, "index" : "22" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.22.0", { "construction" : false, "index" : "23" });
                    skEllipse(sketch, "XYU0VKRP4wky.0.23.0", { "construction" : false, "index" : "24" });
                    skPoint(sketch, "XYU0VKRP4wky.center", { "construction" : true, "index" : "1" });
                    {
                        var VoNlpvIqaxyKOg_query;
                        VoNlpvIqaxyKOg_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FljVSeiGj8mmgBx_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$4hm38ZzH1CYjR4R5R6R7S7$isStartTR8CbA1S11.9$FzHHI0ijqn11CFs_0opThickenRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "9rJN8tN4y2GM.centerSnap0", { "constraintType" : ConstraintType.CONCENTRIC, "index" : "1", "localFirst" : "9rJN8tN4y2GM.center", "externalSecond" : qUnion([VoNlpvIqaxyKOg_query]) });
                    }
                    {
                        skConstraint(sketch, "1KFsrvR9LbT4.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "localFirst" : "1KFsrvR9LbT4.center", "localSecond" : "9rJN8tN4y2GM" });
                    }
                    {
                        var veBUhhnKvToinx_query;
                        veBUhhnKvToinx_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "1KFsrvR9LbT4.centerSnap1", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "localFirst" : "1KFsrvR9LbT4.center", "externalSecond" : qUnion([veBUhhnKvToinx_query]) });
                    }
                    {
                        skConstraint(sketch, "1KFsrvR9LbT4.majorAxisSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "localFirst" : "1KFsrvR9LbT4" });
                    }
                    {
                        skConstraint(sketch, "XYU0VKRP4wky.pattern", { "constraintType" : ConstraintType.CIRCULAR_PATTERN, "index" : "1", "patterng" : 2.0, "patternc1" : { 'value' : try(roundWithinTolerance(24)), 'expression' : "24" }.value, "previouspatternc1" : 24.0, "maximumpatterng" : 2.0, "openPattern" : false, "localInstance1,0" : "1KFsrvR9LbT4", "localInstance0,0" : "1KFsrvR9LbT4.center", "localInstance1,1" : "XYU0VKRP4wky.0.1.0", "localInstance0,1" : "XYU0VKRP4wky.0.1.0.center", "localInstance1,2" : "XYU0VKRP4wky.0.2.0", "localInstance0,2" : "XYU0VKRP4wky.0.2.0.center", "localInstance1,3" : "XYU0VKRP4wky.0.3.0", "localInstance0,3" : "XYU0VKRP4wky.0.3.0.center", "localInstance1,4" : "XYU0VKRP4wky.0.4.0", "localInstance0,4" : "XYU0VKRP4wky.0.4.0.center", "localInstance1,5" : "XYU0VKRP4wky.0.5.0", "localInstance0,5" : "XYU0VKRP4wky.0.5.0.center", "localInstance1,6" : "XYU0VKRP4wky.0.6.0", "localInstance0,6" : "XYU0VKRP4wky.0.6.0.center", "localInstance1,7" : "XYU0VKRP4wky.0.7.0", "localInstance0,7" : "XYU0VKRP4wky.0.7.0.center", "localInstance1,8" : "XYU0VKRP4wky.0.8.0", "localInstance0,8" : "XYU0VKRP4wky.0.8.0.center", "localInstance1,9" : "XYU0VKRP4wky.0.9.0", "localInstance0,9" : "XYU0VKRP4wky.0.9.0.center", "localInstance1,10" : "XYU0VKRP4wky.0.10.0", "localInstance0,10" : "XYU0VKRP4wky.0.10.0.center", "localInstance1,11" : "XYU0VKRP4wky.0.11.0", "localInstance0,11" : "XYU0VKRP4wky.0.11.0.center", "localInstance1,12" : "XYU0VKRP4wky.0.12.0", "localInstance0,12" : "XYU0VKRP4wky.0.12.0.center", "localInstance1,13" : "XYU0VKRP4wky.0.13.0", "localInstance0,13" : "XYU0VKRP4wky.0.13.0.center", "localInstance1,14" : "XYU0VKRP4wky.0.14.0", "localInstance0,14" : "XYU0VKRP4wky.0.14.0.center", "localInstance1,15" : "XYU0VKRP4wky.0.15.0", "localInstance0,15" : "XYU0VKRP4wky.0.15.0.center", "localInstance1,16" : "XYU0VKRP4wky.0.16.0", "localInstance0,16" : "XYU0VKRP4wky.0.16.0.center", "localInstance1,17" : "XYU0VKRP4wky.0.17.0", "localInstance0,17" : "XYU0VKRP4wky.0.17.0.center", "localInstance1,18" : "XYU0VKRP4wky.0.18.0", "localInstance0,18" : "XYU0VKRP4wky.0.18.0.center", "localInstance1,19" : "XYU0VKRP4wky.0.19.0", "localInstance0,19" : "XYU0VKRP4wky.0.19.0.center", "localInstance1,20" : "XYU0VKRP4wky.0.20.0", "localInstance0,20" : "XYU0VKRP4wky.0.20.0.center", "localInstance1,21" : "XYU0VKRP4wky.0.21.0", "localInstance0,21" : "XYU0VKRP4wky.0.21.0.center", "localInstance1,22" : "XYU0VKRP4wky.0.22.0", "localInstance0,22" : "XYU0VKRP4wky.0.22.0.center", "localInstance1,23" : "XYU0VKRP4wky.0.23.0", "localInstance0,23" : "XYU0VKRP4wky.0.23.0.center", "localPivot" : "XYU0VKRP4wky.center", "labelDistance" : 0.003669374325782706 * meter, "labelAngle" : 1.5707963267948966 * radian, "sketchToolType" : SketchToolType.PATTERN });
                    }
                    skSetInitialGuess(sketch, initialGuessFqQRAUkb4iWf3ju_1);
                    skSolve(sketch);
                }
            };
        try(features.FqQRAUkb4iWf3ju_1(id));
        features.F61umKOsPlsnOXx_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var fwaMXsrlehXgkr_query;
                    fwaMXsrlehXgkr_query = qSketchRegion(id + "FqQRAUkb4iWf3ju_1", true);
                    annotation { "Feature Name" : "Thicken 2" }
                    thicken(context, id + "F61umKOsPlsnOXx_1", { "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([fwaMXsrlehXgkr_query]), "midplane" : false, "thickness1" : { 'value' : try(10 * millimeter), 'expression' : "10 mm" }.value, "oppositeDirection" : true, "thickness2" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "keepTools" : false, "defaultScope" : true, "booleanScope" : qUnion([]) });
                }
            };
        try(features.F61umKOsPlsnOXx_1(id));
        features.FuUy2fJGTDiW7tp_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFuUy2fJGTDiW7tp_1 = { "TRdqctkeNBpE" : [0.0, 0.0, 1.0, 0.0, 0.0037480251863331454, -1.0] };
                    {
                    }
                    var YNBWryYjyWdhGc_query;
                    YNBWryYjyWdhGc_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 3" }
                    var sketch = newSketch(context, id + "FuUy2fJGTDiW7tp_1", { "sketchPlane" : qUnion([YNBWryYjyWdhGc_query]), "disableImprinting" : false });
                    skCircle(sketch, "TRdqctkeNBpE", { "construction" : false, "index" : "2" });
                    {
                        var hHyhQVufNcftIm_query;
                        hHyhQVufNcftIm_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "egz1VLNHtjOR.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "localFirst" : "TRdqctkeNBpE.center", "externalSecond" : qUnion([hHyhQVufNcftIm_query]) });
                    }
                    {
                        skConstraint(sketch, "W0QMnCm1CQGo", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "localFirst" : "TRdqctkeNBpE", "length" : 7.496050372666291 * millimeter, "labelRatio" : 0.6262204661089614, "labelAngle" : -0.7737656933272176 * radian });
                    }
                    skSetInitialGuess(sketch, initialGuessFuUy2fJGTDiW7tp_1);
                    skSolve(sketch);
                }
            };
        try(features.FuUy2fJGTDiW7tp_1(id));
        features.F2LkK5Lybk9Ll2E_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var EQjXxsUgMIXdiz_query;
                    EQjXxsUgMIXdiz_query = qSketchRegion(id + "FuUy2fJGTDiW7tp_1", true);
                    annotation { "Feature Name" : "Thicken 3" }
                    thicken(context, id + "F2LkK5Lybk9Ll2E_1", { "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([EQjXxsUgMIXdiz_query]), "midplane" : false, "thickness1" : { 'value' : try(7.5 * millimeter), 'expression' : "7.5 mm" }.value, "oppositeDirection" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "keepTools" : false, "defaultScope" : true, "booleanScope" : qUnion([]) });
                }
            };
        try(features.F2LkK5Lybk9Ll2E_1(id));
        features.FdP9CjeJMYkiqiZ_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFdP9CjeJMYkiqiZ_1 = { "odYLWVTgigSb" : [0.0, 0.021130332490429282, 0.0, -1.0, -0.02581567899324, 0.02581567899324], "jLucuxKz90PB" : [0.06436291432832936, 0.022298701322231426, 1.0, 0.0, 0.021182056059105864, -1.0, -3.373357997154311, -1.9342006688701003], "bopXT3SyOy5l" : [0.04762186513525009, 0.027164135360258954, 1.0, 0.0, -0.0038746499343504624, 0.003874649934350464], "Y0WcIWiFy7p4" : [0.054165045894004324, 0.014832067680129478, 0.21149465503491027, -0.977379154111476, -0.012617485883807717, 0.01261748588380772], "2GZOGdPzTVF4" : [0.0, 0.005012185370093285, 1.0, 0.0, 0.01183794506889794, -1.0, 0.04655247611492188, 1.0198498398948643], "litg8io6pVDP" : [0.011825120184354054, 0.010317266059219836, 0.0, 1.0, -0.004754194058477879, 0.00478119682520628], "IvvuuqUcRcxd" : [0.00901110609627754, 0.015098462884426116, 1.0, 0.0, -0.002814014088076515, 0.002814014088076515] };
                    {
                    }
                    var FpheHdxReUzRRv_query;
                    FpheHdxReUzRRv_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S5.7$FrontplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 4" }
                    var sketch = newSketch(context, id + "FdP9CjeJMYkiqiZ_1", { "sketchPlane" : qUnion([FpheHdxReUzRRv_query]), "disableImprinting" : false });
                    skLineSegment(sketch, "odYLWVTgigSb", { "construction" : true, "index" : "1" });
                    skArc(sketch, "jLucuxKz90PB", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "bopXT3SyOy5l", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "Y0WcIWiFy7p4", { "construction" : false, "index" : "4" });
                    skArc(sketch, "2GZOGdPzTVF4", { "construction" : false, "index" : "4" });
                    skLineSegment(sketch, "litg8io6pVDP", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "IvvuuqUcRcxd", { "construction" : false, "index" : "7" });
                    {
                        var OJlbljqSVVLtWr_query;
                        OJlbljqSVVLtWr_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "odYLWVTgigSb.startSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "localFirst" : "odYLWVTgigSb.start", "externalSecond" : qUnion([OJlbljqSVVLtWr_query]) });
                    }
                    {
                        skConstraint(sketch, "odYLWVTgigSb.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "3", "localFirst" : "odYLWVTgigSb" });
                    }
                    {
                        skConstraint(sketch, "bopXT3SyOy5l.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "localFirst" : "bopXT3SyOy5l.start", "localSecond" : "jLucuxKz90PB.start" });
                    }
                    {
                        skConstraint(sketch, "Y0WcIWiFy7p4.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "localFirst" : "Y0WcIWiFy7p4.start", "localSecond" : "bopXT3SyOy5l.end" });
                    }
                    {
                        skConstraint(sketch, "Y0WcIWiFy7p4.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "localFirst" : "Y0WcIWiFy7p4.end", "localSecond" : "jLucuxKz90PB.end" });
                    }
                    {
                        skConstraint(sketch, "litg8io6pVDP.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "localFirst" : "litg8io6pVDP.start", "localSecond" : "2GZOGdPzTVF4.start" });
                    }
                    {
                        skConstraint(sketch, "litg8io6pVDP.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "4", "localFirst" : "litg8io6pVDP" });
                    }
                    {
                        skConstraint(sketch, "litg8io6pVDP.endSnap1", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "localFirst" : "litg8io6pVDP.end", "localSecond" : "2GZOGdPzTVF4.end" });
                    }
                    {
                        skConstraint(sketch, "IvvuuqUcRcxd.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "localFirst" : "IvvuuqUcRcxd.start", "localSecond" : "2GZOGdPzTVF4.end" });
                    }
                    {
                        skConstraint(sketch, "IvvuuqUcRcxd.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "localFirst" : "IvvuuqUcRcxd.end", "localSecond" : "litg8io6pVDP.end" });
                    }
                    skSetInitialGuess(sketch, initialGuessFdP9CjeJMYkiqiZ_1);
                    skSolve(sketch);
                }
            };
        try(features.FdP9CjeJMYkiqiZ_1(id));
        features.F4AUtzOFYw4oeP2_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var YdwNNPvhIkkdWY_query;
                    YdwNNPvhIkkdWY_query=qCompressed(1.0,"&1d9$eJyFkE9zgjAQxb9MetRp8A96hBBo2iJ0kzqjFwdJRlOrIARb+ukbseO046GXTLLvvd/u5s4foZdGVW084thBUtfZfq03TWZ0cQgyk3k4dm4V0ZaKT5BI0uQ5iRb2qg5GG61qb+A55N7S1kiqSp+UDKti31Wyi6k9h/0M0euDDxENImojW12bomp/8ASoJ1gys0JRqqrrzKTvICY9zDHuj1Eo0yl5U4/xYqePernCH7pSScmn6HjeqgNJxJ+oIA8rOhNMLLhC9U6ZfHsZgEmeIydaJpFMv8Q8HMIIxuDCBKYkt216su8ivS8rfTCQcxexOAU2E0EPXzaFYXdeU7CGHCQoi33XZjPRxbicB+kvA3asAw+C/wHsdGqa42sO+ae8BQC2KeLa7ws9Qv9q3yuFlrs=",id);
                    var AdKSOwzMsCqIDN_query;
                    AdKSOwzMsCqIDN_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FdP9CjeJMYkiqiZ_1wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$UPDvFKAMqIo2",id);
                    var UxMgeTeOlOpVph_query;
                    UxMgeTeOlOpVph_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FdP9CjeJMYkiqiZ_1wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$odYLWVTgigSb",id);
                    annotation { "Feature Name" : "Revolve 1" }
                    revolve(context, id + "F4AUtzOFYw4oeP2_1", { "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "entities" : qUnion([YdwNNPvhIkkdWY_query]), "surfaceEntities" : qUnion([AdKSOwzMsCqIDN_query]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "axis" : qUnion([UxMgeTeOlOpVph_query]), "revolveType" : RevolveType.FULL, "oppositeDirection" : false, "angle" : { 'value' : try(90 * degree), 'expression' : "90 deg" }.value, "angleBack" : { 'value' : try(330 * degree), 'expression' : "330 deg" }.value, "defaultScope" : true, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.F4AUtzOFYw4oeP2_1(id));
        features.FG77qGyHicewJOm_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFG77qGyHicewJOm_1 = { "4G06oQE4t7WO" : [0.0, 0.0, 1.0, 0.0, 0.003, -1.0] };
                    {
                    }
                    var hgaZTuHVjtHpjG_query;
                    hgaZTuHVjtHpjG_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5R1A1M2R2S8$TOPOLOGYS8$entitiesA1A2C0M5R0C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FuUy2fJGTDiW7tp_1wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$TRdqctkeNBpER7R8R9RaRbCeA1S-f.7$imprintReS7$IMPRINTD1R7C9S4$FACER9RaRbR14ReR15R7R1cR9RaS7$isStartTRbCeA1S11.9$F2LkK5Lybk9Ll2E_1opThickenReS8$CAP_FACER7R1cR9RaRbCeA1S-1b.7.9$booleanopBooleanReS4$COPY",id);
                    annotation { "Feature Name" : "Sketch 5" }
                    var sketch = newSketch(context, id + "FG77qGyHicewJOm_1", { "sketchPlane" : qUnion([hgaZTuHVjtHpjG_query]), "disableImprinting" : false });
                    skCircle(sketch, "4G06oQE4t7WO", { "construction" : false, "index" : "3" });
                    {
                        var NFGLpnhYyIBzyo_query;
                        NFGLpnhYyIBzyo_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "RnhDM77aV7U30", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "localFirst" : "4G06oQE4t7WO.center", "externalSecond" : qUnion([NFGLpnhYyIBzyo_query]) });
                    }
                    {
                        skConstraint(sketch, "idStDdwtfUm2", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "localFirst" : "4G06oQE4t7WO", "length" : { 'value' : try(6 * millimeter), 'expression' : "6 mm" }.value, "labelRatio" : 1.137415979680264, "labelAngle" : 0.238825621806916 * radian });
                    }
                    skSetInitialGuess(sketch, initialGuessFG77qGyHicewJOm_1);
                    skSolve(sketch);
                }
            };
        try(features.FG77qGyHicewJOm_1(id));
        features.Fou2p9GUrMUXWHd_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var abHPCarZkUJRvL_query;
                    abHPCarZkUJRvL_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FG77qGyHicewJOm_1wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$4G06oQE4t7WOR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    annotation { "Feature Name" : "Thicken 4" }
                    thicken(context, id + "Fou2p9GUrMUXWHd_1", { "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([abHPCarZkUJRvL_query]), "midplane" : false, "thickness1" : { 'value' : try(6 * millimeter), 'expression' : "6 mm" }.value, "oppositeDirection" : true, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "keepTools" : false, "defaultScope" : true, "booleanScope" : qUnion([]) });
                }
            };
        try(features.Fou2p9GUrMUXWHd_1(id));
        features.FuWug9fUgaANl1L_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var YsXuFWCMkdhjLg_query;
                    YsXuFWCMkdhjLg_query=qCompressed(1.0,"&2bf$eJxlkV1zqjAQhv9MzmUdkorIJUJAWgW6iePxiuEj1oxKEOPp8O9PwNppz7nJbLK7b55999fCRm830fVrm5WoFp38I+qwU2eP+NbaBsucM4YJquW1OJfy/VZoqZqg0IWH1+T/DO9bwfAzSiGO4sRb5QHNaBLQxN8xF6lOvsumOF09PMrjQQQImyOeZukqjXYmFI2WWgpT8w3CZsU90Q8/LApEvy5simgQUcN/kFetuvvjHPlAPR6niUmoVnQjXlwvCIprDzOMJzMU3jY92b9EPJBbR7c5/pCdSFtDehlMGYVqxF4p95c5TXjMd0yg61Ho6nAHiGtWIQ71pdJHkSxaCg7MwYUCSl+Yb572EwfJc9vJRoNgDorXGcQJDzA4vmvQQ8+n93rAUxCAbaOAq+HJVMsr00Wn+aeagXZRSFbHV3vVl0d3dSI0x6rlB1kdRQPj2F6Wj6IPmQcJLieOaS+VOomiUe3iHsBgoJ9mu+8bgWeYfu7o5zyG4AlbKIwc5xL1S1mJj5f0nGNDvgdsGTOmkTVTb3SqnW36L8PYXaFQ3UjrRptuvfm9XdZDt1kv29KMP9B/eEhmpm0/eSIWMpUuMv5RYNTnfwE/T9tr",id);
                    annotation { "Feature Name" : "Chamfer 1" }
                    chamfer(context, id + "FuWug9fUgaANl1L_1", { "entities" : qUnion([YsXuFWCMkdhjLg_query]), "chamferMethod" : ChamferMethod.FACE_OFFSET, "chamferType" : ChamferType.EQUAL_OFFSETS, "width" : { 'value' : try(1 * millimeter), 'expression' : "1 mm" }.value, "width1" : 5.0 * millimeter, "oppositeDirection" : false, "width2" : 5.0 * millimeter, "angle" : 45.0 * degree, "directionOverrides" : qUnion([]), "tangentPropagation" : true });
                }
            };
        try(features.FuWug9fUgaANl1L_1(id));
        features.FgDls4enSYZERNk_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFgDls4enSYZERNk_1 = { "NeFVQvLLLgiR" : [0.0012134515962085855, 0.003967996378421072, 0.279329540829103, 0.9601952966038745, 0.0, 4.864847729226651E-7], "JmJ0Ja6H86Zg" : [6.468855207209919E-4, 0.003713050562204572, 0.0014436060593190836, 0.0043530754234443955, 0.001735352469234901, 0.0033499536358641167, 0.5, 0.0, 1.0], "JmJ0Ja6H86Zg.snap10" : [0.0014436060593190836, 0.0038495006749147548], "o4tkUuBy7mep" : [-0.003275159197856203, 0.0017590519949744427, -0.0036273168060074012, 0.0026833133864649027, -0.0025947856089666155, 0.0026833133864649027, 0.5, 0.0, 1.0], "aloh5qfD4cPW" : [-0.0032991521997487866, -0.0016469775675008852, -0.003633605503556434, -0.0025805049289257934, -0.0026315352440778412, -0.0025805049289257934, 0.5, 0.0, 0.9999999999999999], "zB1YRiq6D0fN" : [5.951285814173198E-4, -0.003656580447435856, 0.0013905326898228836, -0.004273618170005187, 0.0016884875543877222, -0.003309272190305274, 0.5, 0.0, 1.0], "zB1YRiq6D0fN.snap10" : [0.0013905326898228836, -0.0038053965108558394], "bILPwf5CC5VT" : [0.0037062783075907427, -5.685842379491934E-4, 0.004546295923343543, -2.2927085586553313E-5, 0.0037155182714494767, 5.802014973841117E-4, 0.5, 0.0, 1.0], "DBzwcFVpr9Tl" : [0.002260526102095394, -0.0016162197924889155, 1.0, 0.0, 5.821181570969582E-5, -1.0, 2.214897350911243, 2.7868870015793785], "faMITqAyrl65" : [-8.45741731030753E-4, -0.0025968761259014504, 1.0, 0.0, 5.265720769346072E-5, -1.0, 0.9141645525925747, 1.5429037655674913], "HqijhUvyBawM" : [0.0022762780031046607, 0.0016432477234835804, 1.0, 0.0, 5.0018512682238955E-5, -1.0, -2.8537477168481193, -2.179392151488473], "2Wu6mQO3Wjt5" : [-8.069898546963798E-4, 0.0026715500460587492, 1.0, 0.0, 5.008390457479388E-5, -1.0, -1.5972259652121057, -0.9344924797780247], "L9rpyfoyaVKk" : [-0.0027338153363324173, 5.260157320654581E-5, 1.0, 0.0, 4.841065868592356E-5, -1.0, -0.37315770193832676, 0.3267208684778102], "0tbGQeQz4n60" : [-0.0029815222037162855, 9.134794586836497E-4, 0.32804700101571876, -0.9446614023683795, -8.951064732515181E-4, 8.948613867298063E-4], "LDRsB8taIR1A" : [-0.0029939442294790765, -8.060122347932647E-4, -0.34115302216260707, -0.9400077741536608, -8.946365719845092E-4, 8.946365719845099E-4], "sFkYocv89za6" : [-0.0017379042105787447, -0.002562372164663609, 0.9997941990063751, 0.02028693257249053, -8.938149815104073E-4, 8.938149815104073E-4], "5NGAjN1JjaUP" : [-1.0923421258525641E-4, -0.0031058746406291645, 0.787795135600547, -0.6159373542204724, -8.940938604113634E-4, 8.940938604116043E-4], "ESCYJcH3Ji1B" : [0.001947212799220931, -0.0024526370917598416, 0.2891258737852993, 0.9572910890151893, -8.948533088579079E-4, 8.948533088579072E-4], "JAsPd8xt8geR" : [0.002966192637493518, -0.0010689466169083828, 0.8284308220474779, 0.5600913970788518, -8.940053128816358E-4, 8.933584439411526E-4], "lcUOjGtEjW1M" : [0.002981599946123853, 0.0010912057256570874, -0.8206680087587961, 0.5714053022154, -8.942938161262369E-4, 8.942938161262368E-4], "sGTFq9cGUNmd" : [0.0019818349132793805, 0.0024895008897609064, -0.27538089692312534, 0.961335197321837, -8.950600669780176E-4, 8.95060066978019E-4], "KJMZiUh4qTqU" : [-6.517157031383017E-5, 0.00317215912201655, -0.7963086819732621, -0.6048904719153759, -8.941973221619742E-4, 8.941973221619754E-4], "vJWposNbqW2k" : [-0.0017015495045252195, 0.002652398509690032, -0.9994016124412662, 0.0345892620591622, -8.937709258437796E-4, 8.937709258437791E-4], "KD2zESgbmQpn0" : [-0.004340758518073577, -0.002580504928925793], "KD2zESgbmQpn1" : [-0.003544976956144012, -0.012176327447298787], "z1TEl4v3yvx00" : [-0.0032626371062806276, -0.012176327447298787], "z1TEl4v3yvx00.positionSnap0" : [3.141592653589793] };
                    {
                    }
                    var ILJTEFodBVzpUv_query;
                    ILJTEFodBVzpUv_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5R0A1M2R1S8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FljVSeiGj8mmgBx_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$4hm38ZzH1CYjR7R8R9RaRbCeA1S-f.7$imprintReS7$IMPRINTD1R7C9S4$FACER9RaRbR14ReR15R7R1cR9RaS7$isStartTRbCeA1S11.9$FzHHI0ijqn11CFs_0opThickenReS8$CAP_FACE",id);
                    annotation { "Feature Name" : "Sketch 6" }
                    var sketch = newSketch(context, id + "FgDls4enSYZERNk_1", { "sketchPlane" : qUnion([ILJTEFodBVzpUv_query]), "disableImprinting" : false });
                    skLineSegment(sketch, "NeFVQvLLLgiR", { "construction" : true, "index" : "72" });
                    skConicSegment(sketch, "JmJ0Ja6H86Zg", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "JmJ0Ja6H86Zg.snap10", { "construction" : false, "index" : "1" });
                    skConicSegment(sketch, "o4tkUuBy7mep", { "construction" : false, "index" : "2" });
                    skConicSegment(sketch, "aloh5qfD4cPW", { "construction" : false, "index" : "3" });
                    skConicSegment(sketch, "zB1YRiq6D0fN", { "construction" : false, "index" : "4" });
                    skPoint(sketch, "zB1YRiq6D0fN.snap10", { "construction" : false, "index" : "2" });
                    skConicSegment(sketch, "bILPwf5CC5VT", { "construction" : false, "index" : "5" });
                    skArc(sketch, "DBzwcFVpr9Tl", { "construction" : false, "index" : "13" });
                    skArc(sketch, "faMITqAyrl65", { "construction" : false, "index" : "14" });
                    skArc(sketch, "HqijhUvyBawM", { "construction" : false, "index" : "15" });
                    skArc(sketch, "2Wu6mQO3Wjt5", { "construction" : false, "index" : "16" });
                    skArc(sketch, "L9rpyfoyaVKk", { "construction" : false, "index" : "17" });
                    skLineSegment(sketch, "0tbGQeQz4n60", { "construction" : false, "index" : "103" });
                    skLineSegment(sketch, "LDRsB8taIR1A", { "construction" : false, "index" : "104" });
                    skLineSegment(sketch, "sFkYocv89za6", { "construction" : false, "index" : "105" });
                    skLineSegment(sketch, "5NGAjN1JjaUP", { "construction" : false, "index" : "106" });
                    skLineSegment(sketch, "ESCYJcH3Ji1B", { "construction" : false, "index" : "107" });
                    skLineSegment(sketch, "JAsPd8xt8geR", { "construction" : false, "index" : "108" });
                    skLineSegment(sketch, "lcUOjGtEjW1M", { "construction" : false, "index" : "109" });
                    skLineSegment(sketch, "sGTFq9cGUNmd", { "construction" : false, "index" : "110" });
                    skLineSegment(sketch, "KJMZiUh4qTqU", { "construction" : false, "index" : "111" });
                    skLineSegment(sketch, "vJWposNbqW2k", { "construction" : false, "index" : "112" });
                    skPoint(sketch, "KD2zESgbmQpn0", { "construction" : false, "index" : "3" });
                    skPoint(sketch, "KD2zESgbmQpn1", { "construction" : false, "index" : "4" });
                    skPoint(sketch, "z1TEl4v3yvx00", { "construction" : false, "index" : "5" });
                    {
                        skConstraint(sketch, "JmJ0Ja6H86Zg.snap00", { "constraintType" : ConstraintType.COINCIDENT, "index" : "24", "localFirst" : "JmJ0Ja6H86Zg.0.internal", "localSecond" : "KJMZiUh4qTqU.start" });
                    }
                    {
                        skConstraint(sketch, "JmJ0Ja6H86Zg.snap11", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "localFirst" : "JmJ0Ja6H86Zg.1.internal", "localSecond" : "JmJ0Ja6H86Zg.snap10" });
                    }
                    {
                        skConstraint(sketch, "JmJ0Ja6H86Zg.snap20", { "constraintType" : ConstraintType.COINCIDENT, "index" : "25", "localFirst" : "JmJ0Ja6H86Zg.2.internal", "localSecond" : "sGTFq9cGUNmd.end" });
                    }
                    {
                        skConstraint(sketch, "JmJ0Ja6H86Zg.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "26", "localFirst" : "JmJ0Ja6H86Zg.start", "localSecond" : "JmJ0Ja6H86Zg.0.internal" });
                    }
                    {
                        skConstraint(sketch, "JmJ0Ja6H86Zg.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "27", "localFirst" : "JmJ0Ja6H86Zg.end", "localSecond" : "JmJ0Ja6H86Zg.2.internal" });
                    }
                    {
                        skConstraint(sketch, "JmJ0Ja6H86Zg.rho", { "constraintType" : ConstraintType.RHO, "index" : "1", "localFirst" : "JmJ0Ja6H86Zg", "rho" : 0.5, "labelDistance" : 5.116219379606448E-4 * meter, "labelAngle" : 1.902870128164771 * radian });
                    }
                    {
                        skConstraint(sketch, "o4tkUuBy7mep.snap00", { "constraintType" : ConstraintType.COINCIDENT, "index" : "28", "localFirst" : "o4tkUuBy7mep.0.internal", "localSecond" : "0tbGQeQz4n60.start" });
                    }
                    {
                        skConstraint(sketch, "o4tkUuBy7mep.snap10", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "localFirst" : "o4tkUuBy7mep.1.internal", "localSecond" : "o4tkUuBy7mep.2.internal" });
                    }
                    {
                        skConstraint(sketch, "o4tkUuBy7mep.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "30", "localFirst" : "o4tkUuBy7mep.start", "localSecond" : "o4tkUuBy7mep.0.internal" });
                    }
                    {
                        skConstraint(sketch, "o4tkUuBy7mep.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "31", "localFirst" : "o4tkUuBy7mep.end", "localSecond" : "o4tkUuBy7mep.2.internal" });
                    }
                    {
                        skConstraint(sketch, "o4tkUuBy7mep.rho", { "constraintType" : ConstraintType.RHO, "index" : "2", "localFirst" : "o4tkUuBy7mep", "rho" : 0.5, "labelDistance" : 7.725181583802845E-4 * meter, "labelAngle" : 2.7816974125457863 * radian });
                    }
                    {
                        skConstraint(sketch, "aloh5qfD4cPW.snap00", { "constraintType" : ConstraintType.COINCIDENT, "index" : "32", "localFirst" : "aloh5qfD4cPW.0.internal", "localSecond" : "LDRsB8taIR1A.end" });
                    }
                    {
                        skConstraint(sketch, "aloh5qfD4cPW.snap10", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "localFirst" : "aloh5qfD4cPW.1.internal", "localSecond" : "aloh5qfD4cPW.2.internal" });
                    }
                    {
                        skConstraint(sketch, "aloh5qfD4cPW.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "34", "localFirst" : "aloh5qfD4cPW.start", "localSecond" : "aloh5qfD4cPW.0.internal" });
                    }
                    {
                        skConstraint(sketch, "aloh5qfD4cPW.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "35", "localFirst" : "aloh5qfD4cPW.end", "localSecond" : "aloh5qfD4cPW.2.internal" });
                    }
                    {
                        skConstraint(sketch, "aloh5qfD4cPW.rho", { "constraintType" : ConstraintType.RHO, "index" : "3", "localFirst" : "aloh5qfD4cPW", "rho" : 0.5, "labelDistance" : 7.602467242832496E-4 * meter, "labelAngle" : -2.77177174981766 * radian });
                    }
                    {
                        skConstraint(sketch, "zB1YRiq6D0fN.snap00", { "constraintType" : ConstraintType.COINCIDENT, "index" : "36", "localFirst" : "zB1YRiq6D0fN.0.internal", "localSecond" : "5NGAjN1JjaUP.end" });
                    }
                    {
                        skConstraint(sketch, "zB1YRiq6D0fN.snap11", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "localFirst" : "zB1YRiq6D0fN.1.internal", "localSecond" : "zB1YRiq6D0fN.snap10" });
                    }
                    {
                        skConstraint(sketch, "zB1YRiq6D0fN.snap20", { "constraintType" : ConstraintType.COINCIDENT, "index" : "37", "localFirst" : "zB1YRiq6D0fN.2.internal", "localSecond" : "ESCYJcH3Ji1B.start" });
                    }
                    {
                        skConstraint(sketch, "zB1YRiq6D0fN.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "38", "localFirst" : "zB1YRiq6D0fN.start", "localSecond" : "zB1YRiq6D0fN.0.internal" });
                    }
                    {
                        skConstraint(sketch, "zB1YRiq6D0fN.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "39", "localFirst" : "zB1YRiq6D0fN.end", "localSecond" : "zB1YRiq6D0fN.2.internal" });
                    }
                    {
                        skConstraint(sketch, "zB1YRiq6D0fN.rho", { "constraintType" : ConstraintType.RHO, "index" : "4", "localFirst" : "zB1YRiq6D0fN", "rho" : 0.5, "labelDistance" : 4.952218839975217E-4 * meter, "labelAngle" : -1.9190673277322767 * radian });
                    }
                    {
                        skConstraint(sketch, "bILPwf5CC5VT.snap20", { "constraintType" : ConstraintType.COINCIDENT, "index" : "41", "localFirst" : "bILPwf5CC5VT.2.internal", "localSecond" : "lcUOjGtEjW1M.start" });
                    }
                    {
                        skConstraint(sketch, "bILPwf5CC5VT.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "42", "localFirst" : "bILPwf5CC5VT.start", "localSecond" : "bILPwf5CC5VT.0.internal" });
                    }
                    {
                        skConstraint(sketch, "bILPwf5CC5VT.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "43", "localFirst" : "bILPwf5CC5VT.end", "localSecond" : "bILPwf5CC5VT.2.internal" });
                    }
                    {
                        skConstraint(sketch, "bILPwf5CC5VT.rho", { "constraintType" : ConstraintType.RHO, "index" : "5", "localFirst" : "bILPwf5CC5VT", "rho" : 0.5, "labelDistance" : 1.7703720059692083E-4 * meter, "labelAngle" : -0.09632832613084955 * radian });
                    }
                    {
                        skConstraint(sketch, "DBzwcFVpr9Tl.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "56", "localFirst" : "DBzwcFVpr9Tl.end", "localSecond" : "ESCYJcH3Ji1B.end" });
                    }
                    {
                        skConstraint(sketch, "faMITqAyrl65.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "57", "localFirst" : "faMITqAyrl65.start", "localSecond" : "5NGAjN1JjaUP.start" });
                    }
                    {
                        skConstraint(sketch, "HqijhUvyBawM.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "60", "localFirst" : "HqijhUvyBawM.end", "localSecond" : "lcUOjGtEjW1M.end" });
                    }
                    {
                        skConstraint(sketch, "2Wu6mQO3Wjt5.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "61", "localFirst" : "2Wu6mQO3Wjt5.start", "localSecond" : "vJWposNbqW2k.start" });
                    }
                    {
                        skConstraint(sketch, "0tbGQeQz4n60.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "66", "localFirst" : "0tbGQeQz4n60.end", "localSecond" : "L9rpyfoyaVKk.end" });
                    }
                    {
                        skConstraint(sketch, "sFkYocv89za6.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "69", "localFirst" : "sFkYocv89za6.start", "localSecond" : "aloh5qfD4cPW.2.internal" });
                    }
                    {
                        skConstraint(sketch, "sFkYocv89za6.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "70", "localFirst" : "sFkYocv89za6.end", "localSecond" : "faMITqAyrl65.end" });
                    }
                    {
                        skConstraint(sketch, "JAsPd8xt8geR.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "75", "localFirst" : "JAsPd8xt8geR.start", "localSecond" : "DBzwcFVpr9Tl.start" });
                    }
                    {
                        skConstraint(sketch, "JAsPd8xt8geR.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "76", "localFirst" : "JAsPd8xt8geR.end", "localSecond" : "bILPwf5CC5VT.0.internal" });
                    }
                    {
                        skConstraint(sketch, "KJMZiUh4qTqU.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "82", "localFirst" : "KJMZiUh4qTqU.end", "localSecond" : "2Wu6mQO3Wjt5.end" });
                    }
                    {
                        skConstraint(sketch, "vJWposNbqW2k.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "84", "localFirst" : "vJWposNbqW2k.end", "localSecond" : "o4tkUuBy7mep.2.internal" });
                    }
                    {
                        skConstraint(sketch, "0ExgK317R5c8", { "constraintType" : ConstraintType.COINCIDENT, "index" : "85", "localFirst" : "L9rpyfoyaVKk.start", "localSecond" : "LDRsB8taIR1A.start" });
                    }
                    {
                        skConstraint(sketch, "KD2zESgbmQpn2", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "3", "localFirst" : "aloh5qfD4cPW.2.internal", "localSecond" : "KD2zESgbmQpn0" });
                    }
                    {
                        var XILbiJiweIFfSj_query;
                        XILbiJiweIFfSj_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5R0A1M2R1S8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FljVSeiGj8mmgBx_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$4hm38ZzH1CYjR7R8R9RaRbCeA1S-f.7$imprintReS7$IMPRINTD1R7C9S4$FACER9RaRbR14ReR15R7R1cR9RaS7$isStartTRbCeA1S11.9$FzHHI0ijqn11CFs_0opThickenReS8$CAP_FACE",id);
                        var uWmylXDtXEyUQD_query;
                        uWmylXDtXEyUQD_query=qCompressed(1.0,"&29f$eJxlkVuTojAQRv9M9lGKRvDyiBiUcgSmk7m4LxSXqEG5CLgzzq+fgFNTs7svVEh3Tp98+bWwyONVNLetxRKSiUb+EZnbVIVtOPp2wsAgmWzjIpGHa9zJqlzGXWzD1vi/wm+1YDAmAXorz7cfoiUNqb+kvrNjc1I18iDL+NzaoMAWQg9Bg80ID8LgIVjt1FKUneykUD3DeAv1/svie+HWT1jEhH7/MJPQ5Yoq86Nsu6q5b86Ig9TmXuCrQlWLZtDzsoVBvMwGBqBNiHvOn5mQq3xWFIfFe6S/yUYEtTK99HEMoIywDeXOOqI+9/iOCdKeRJce7wJexlJiHovx7PfHGpxdjlOc4RxjTByhxoz22pTIom5k2aFgU+JtQ/R8vgScOnOl7toOvfcjmCgQLEWAtN9S3bJlXdx0/IumpOfE/VivPV3mlxLAcdtIr2p+lOlJlDhc2w6jHvozYByj+RX533oKOAKduJdHtJ9OiSlf9uP8GoES2SPoLNVAM7SRYZDX3ZP+vMHQfDvddIBvyZ+glLgTuBaboA3PbRm8vvcg9XDshYZ8kPo3HcPSpupKSVWdRVxW9eK+UKfmRKVEkVGHfwIeFtLR",id);
                        skConstraint(sketch, "z1TEl4v3yvx00.positionSnap0", { "constraintType" : ConstraintType.QUADRANT, "index" : "1", "localFirst" : "z1TEl4v3yvx00", "externalSecond" : qUnion([qCoEdge(XILbiJiweIFfSj_query, uWmylXDtXEyUQD_query)]) });
                    }
                    {
                        skConstraint(sketch, "z1TEl4v3yvx02", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "4", "localFirst" : "KD2zESgbmQpn1", "localSecond" : "z1TEl4v3yvx00" });
                    }
                    skSetInitialGuess(sketch, initialGuessFgDls4enSYZERNk_1);
                    skSolve(sketch);
                }
            };
        try(features.FgDls4enSYZERNk_1(id));
        features.Fv5NWYVGcppvujf_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var TGRiTQBHQbpOnQ_query;
                    TGRiTQBHQbpOnQ_query=qCompressed(1.0,"&29f$eJydkstuwjAQRX/GXRbhNA9Y5k1CSajtCMEGJbFLrJC3ocrfN4QKtQIJqRvLnrn3zB3JL4YCPk6s7VcKhhKgvIuLhB9OseBVacUi1uFKuu+QvmZ4Bki4Dt9DdztcWSm44KzTVV0ypwMtAZS1/Myo01bFWImvov5iNmJg3x5YBrbl2oMl452o2v4HbyJbJ14YDI2qZu042aOGBDyqQwzhRAXOwTp2MivxdmejIN/DL96ysMZz0Fy2GkEU4KVNzMXeDohHtpiBLmciza4BPIpT4Bf+1I/VxUzdHZCCVKShGZqb6TDmlU40wIu65aVAKdaAt1ojLyDWK7xuiuTxvLlQglJEERuwlSzy6GT0WsHqXwIoDQr4hqDylBAfq0xpPi05XW/uCdbzCJ1LnGaeulFQ0EcR2FPC0l/teJTJDWmi/xHO/qauuiBpNlL+kIAUUxs+gaOb9t/eN73Fz58=",id);
                    annotation { "Feature Name" : "Thicken 5" }
                    thicken(context, id + "Fv5NWYVGcppvujf_1", { "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([TGRiTQBHQbpOnQ_query]), "midplane" : false, "thickness1" : { 'value' : try(1.5 * millimeter), 'expression' : "1.5 mm" }.value, "oppositeDirection" : true, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "keepTools" : false, "defaultScope" : true, "booleanScope" : qUnion([]) });
                }
            };
        try(features.Fv5NWYVGcppvujf_1(id));
        features.FN2JPEXoQns5GFK_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var UpBVkTAJdYtvvR_query;
                    UpBVkTAJdYtvvR_query = qSketchRegion(id + "FgDls4enSYZERNk_1", true);
                    annotation { "Feature Name" : "Thicken 6" }
                    thicken(context, id + "FN2JPEXoQns5GFK_1", { "operationType" : NewBodyOperationType.NEW, "entities" : qUnion([UpBVkTAJdYtvvR_query]), "midplane" : false, "thickness1" : { 'value' : try(1.5 * millimeter), 'expression' : "1.5 mm" }.value, "oppositeDirection" : true, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "keepTools" : false, "defaultScope" : false, "booleanScope" : qUnion([]) });
                }
            };
        try(features.FN2JPEXoQns5GFK_1(id));
        return context;
    }, millimeter, {});

