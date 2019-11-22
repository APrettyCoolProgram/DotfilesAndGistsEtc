This is experimental

You will need to extract the "CSharp_NETCore_WPF_SolutionTemplate.vstemplate" file, and make the following modifications:

```
<VSTemplate Version="2.0.0" Type="ProjectGroup"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>CSharp NETCore WPF Solution Template</Name>
        <Description>A CSharp NETCore WPF Solution Template</Description>
        <Icon>Icon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
    </TemplateData>
    <TemplateContent>
        <ProjectCollection>
            <ProjectTemplateLink ProjectName="YOUR-APPLICATION-NAME-HERE-ClassLibrary">
               CSharp_NETCore_ClassLibrary_ProjectTemplate\CSharp_NETCore_ClassLibrary_ProjectTemplate.vstemplate
            </ProjectTemplateLink>
			<ProjectTemplateLink ProjectName="YOUR-APPLICATION-NAME-HERE-">
                CSharp_NETCore_WPF_ProjectTemplate\CSharp_NETCore_WPF_ProjectTemplate.vstemplate
            </ProjectTemplateLink>
            <ProjectTemplateLink ProjectName="YOUR-APPLICATION-NAME-HERE--XUnit">
                CSharp_NETCore_xUnit_ProjectTemplate\CSharp_NETCore_xUnit_ProjectTemplate.vstemplate
            </ProjectTemplateLink>
        </ProjectCollection>
    </TemplateContent>
</VSTemplate>
```