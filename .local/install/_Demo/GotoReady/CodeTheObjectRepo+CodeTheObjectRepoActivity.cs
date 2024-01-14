using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using Template.POS.ObjectRepository;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Template.POS._Demo.GotoReady
{
    public class CodeTheObjectRepoActivity : System.Activities.Activity
    {
        public CodeTheObjectRepoActivity()
        {
            this.Implementation = () =>
            {
                return new CodeTheObjectRepoActivityChild()
                {};
            };
        }
    }

    internal class CodeTheObjectRepoActivityChild : CodeActivity
    {
        public CodeTheObjectRepoActivityChild()
        {
            DisplayName = "CodeTheObjectRepo";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new global::Template.POS._Demo.GotoReady.CodeTheObjectRepo();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "_Demo\\GotoReady\\CodeTheObjectRepo.cs"});
                }
            }, () =>
            {
                codedWorkflow.Execute();
                return null;
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "_Demo\\GotoReady\\CodeTheObjectRepo.cs", Exception = exception});
                }
            });
        }
    }
}