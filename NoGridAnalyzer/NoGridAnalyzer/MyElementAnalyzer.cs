using System;
using RapidXaml;

namespace NoGridAnalyzer
{
    public class MyElementAnalyzer : ICustomAnalyzer
    {
        public string TargetType() => "Grid";

        public AnalysisActions Analyze(RapidXamlElement element, ExtraAnalysisDetails extraDetails)
        {
            return AnalysisActions.HighlightWithoutAction(
                errorType: RapidXamlErrorType.Error,
                code: "NOGRD01",
                description: "Do not use Grids!");
        }
    }
}
