// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_LabServices_2018_10_15
    {
        private const string ProviderNamespace = "Microsoft.LabServices";
        private const string ApiVersion = "2018-10-15";
        private static readonly ResourceTypeReference ResourceTypeReference_labaccounts = new ResourceTypeReference(ProviderNamespace, new[]{"labaccounts"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_labaccounts_galleryimages = new ResourceTypeReference(ProviderNamespace, new[]{"labaccounts", "galleryimages"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_labaccounts_labs = new ResourceTypeReference(ProviderNamespace, new[]{"labaccounts", "labs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_labaccounts_labs_environmentsettings = new ResourceTypeReference(ProviderNamespace, new[]{"labaccounts", "labs", "environmentsettings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_labaccounts_labs_users = new ResourceTypeReference(ProviderNamespace, new[]{"labaccounts", "labs", "users"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_labaccounts_labs_environmentsettings_environments = new ResourceTypeReference(ProviderNamespace, new[]{"labaccounts", "labs", "environmentsettings", "environments"}, ApiVersion);
        private static Lazy<Microsoft_LabServices_2018_10_15> InstanceLazy = new Lazy<Microsoft_LabServices_2018_10_15>(() => new Microsoft_LabServices_2018_10_15());
        private Microsoft_LabServices_2018_10_15()
        {
            LabAccountProperties = new NamedObjectType("LabAccountProperties", new ITypeProperty[]{new TypeProperty("enabledRegionSelection", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uniqueIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GalleryImageProperties = new NamedObjectType("GalleryImageProperties", new ITypeProperty[]{new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isOverride", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isPlanAuthorized", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uniqueIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LabProperties = new NamedObjectType("LabProperties", new ITypeProperty[]{new TypeProperty("maxUsersInLab", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("usageQuota", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userAccessMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uniqueIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EnvironmentSettingProperties = new NamedObjectType("EnvironmentSettingProperties", new ITypeProperty[]{new TypeProperty("configurationState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("title", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("resourceSettings", () => ResourceSettings, TypePropertyFlags.Required), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uniqueIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceSettings = new NamedObjectType("ResourceSettings", new ITypeProperty[]{new TypeProperty("galleryImageResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("size", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("referenceVm", () => ReferenceVm, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ReferenceVm = new NamedObjectType("ReferenceVm", new ITypeProperty[]{new TypeProperty("userName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EnvironmentProperties = new NamedObjectType("EnvironmentProperties", new ITypeProperty[]{new LazyTypeProperty("resourceSets", () => ResourceSet, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uniqueIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceSet = new NamedObjectType("ResourceSet", new ITypeProperty[]{new TypeProperty("vmResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceSettingId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UserProperties = new NamedObjectType("UserProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uniqueIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_labaccounts = new ResourceType("Microsoft.LabServices/labaccounts", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => LabAccountProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_labaccounts);
            ResourceType_labaccounts_galleryimages = new ResourceType("Microsoft.LabServices/labaccounts/galleryimages", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => GalleryImageProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_labaccounts_galleryimages);
            ResourceType_labaccounts_labs = new ResourceType("Microsoft.LabServices/labaccounts/labs", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => LabProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_labaccounts_labs);
            ResourceType_labaccounts_labs_environmentsettings = new ResourceType("Microsoft.LabServices/labaccounts/labs/environmentsettings", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => EnvironmentSettingProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_labaccounts_labs_environmentsettings);
            ResourceType_labaccounts_labs_users = new ResourceType("Microsoft.LabServices/labaccounts/labs/users", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => UserProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_labaccounts_labs_users);
            ResourceType_labaccounts_labs_environmentsettings_environments = new ResourceType("Microsoft.LabServices/labaccounts/labs/environmentsettings/environments", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => EnvironmentProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_labaccounts_labs_environmentsettings_environments);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_labaccounts, () => InstanceLazy.Value.ResourceType_labaccounts);
            registrar.RegisterType(ResourceTypeReference_labaccounts_galleryimages, () => InstanceLazy.Value.ResourceType_labaccounts_galleryimages);
            registrar.RegisterType(ResourceTypeReference_labaccounts_labs, () => InstanceLazy.Value.ResourceType_labaccounts_labs);
            registrar.RegisterType(ResourceTypeReference_labaccounts_labs_environmentsettings, () => InstanceLazy.Value.ResourceType_labaccounts_labs_environmentsettings);
            registrar.RegisterType(ResourceTypeReference_labaccounts_labs_users, () => InstanceLazy.Value.ResourceType_labaccounts_labs_users);
            registrar.RegisterType(ResourceTypeReference_labaccounts_labs_environmentsettings_environments, () => InstanceLazy.Value.ResourceType_labaccounts_labs_environmentsettings_environments);
        }
        private readonly ResourceType ResourceType_labaccounts;
        private readonly ResourceType ResourceType_labaccounts_galleryimages;
        private readonly ResourceType ResourceType_labaccounts_labs;
        private readonly ResourceType ResourceType_labaccounts_labs_environmentsettings;
        private readonly ResourceType ResourceType_labaccounts_labs_users;
        private readonly ResourceType ResourceType_labaccounts_labs_environmentsettings_environments;
        private readonly TypeSymbol LabAccountProperties;
        private readonly TypeSymbol GalleryImageProperties;
        private readonly TypeSymbol LabProperties;
        private readonly TypeSymbol EnvironmentSettingProperties;
        private readonly TypeSymbol ResourceSettings;
        private readonly TypeSymbol ReferenceVm;
        private readonly TypeSymbol EnvironmentProperties;
        private readonly TypeSymbol ResourceSet;
        private readonly TypeSymbol UserProperties;
    }
}