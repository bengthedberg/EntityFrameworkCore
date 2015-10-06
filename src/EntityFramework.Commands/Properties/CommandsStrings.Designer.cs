// <auto-generated />
namespace Microsoft.Data.Entity.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

    public static class CommandsStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Commands.CommandsStrings", typeof(CommandsStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// The name '{migrationName}' is used by an existing migration.
        /// </summary>
        public static string DuplicateMigrationName([CanBeNull] object migrationName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DuplicateMigrationName", "migrationName"), migrationName);
        }

        /// <summary>
        /// More than one DbContext was found. Specify which one to use.
        /// </summary>
        public static string MultipleContexts
        {
            get { return GetString("MultipleContexts"); }
        }

        /// <summary>
        /// More than one DbContext named '{name}' was found. Specify which one to use by providing its fully qualified name.
        /// </summary>
        public static string MultipleContextsWithName([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MultipleContextsWithName", "name"), name);
        }

        /// <summary>
        /// More than one DbContext named '{name}' was found. Specify which one to use by providing its fully qualified name using its exact case.
        /// </summary>
        public static string MultipleContextsWithQualifiedName([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MultipleContextsWithQualifiedName", "name"), name);
        }

        /// <summary>
        /// No DbContext was found. Ensure that you're using the correct assembly and that the type is neither abstract nor generic.
        /// </summary>
        public static string NoContext
        {
            get { return GetString("NoContext"); }
        }

        /// <summary>
        /// No DbContext named '{name}' was found.
        /// </summary>
        public static string NoContextWithName([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoContextWithName", "name"), name);
        }

        /// <summary>
        /// Using context '{name}'.
        /// </summary>
        public static string LogUseContext([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogUseContext", "name"), name);
        }

        /// <summary>
        /// A manual migration deletion was detected.
        /// </summary>
        public static string ManuallyDeleted
        {
            get { return GetString("ManuallyDeleted"); }
        }

        /// <summary>
        /// No file named '{file}' was found. You must manually remove the migration class '{migrationClass}'.
        /// </summary>
        public static string NoMigrationFile([CanBeNull] object file, [CanBeNull] object migrationClass)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoMigrationFile", "file", "migrationClass"), file, migrationClass);
        }

        /// <summary>
        /// No file named '{file}' was found.
        /// </summary>
        public static string NoMigrationMetadataFile([CanBeNull] object file)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoMigrationMetadataFile", "file"), file);
        }

        /// <summary>
        /// No ModelSnapshot was found.
        /// </summary>
        public static string NoSnapshot
        {
            get { return GetString("NoSnapshot"); }
        }

        /// <summary>
        /// No file named '{file}' was found. You must manually remove the model snapshot class '{snapshotClass}'.
        /// </summary>
        public static string NoSnapshotFile([CanBeNull] object file, [CanBeNull] object snapshotClass)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoSnapshotFile", "file", "snapshotClass"), file, snapshotClass);
        }

        /// <summary>
        /// Removing migration '{name}'.
        /// </summary>
        public static string RemovingMigration([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RemovingMigration", "name"), name);
        }

        /// <summary>
        /// Removing model snapshot.
        /// </summary>
        public static string RemovingSnapshot
        {
            get { return GetString("RemovingSnapshot"); }
        }

        /// <summary>
        /// Reverting model snapshot.
        /// </summary>
        public static string RevertingSnapshot
        {
            get { return GetString("RevertingSnapshot"); }
        }

        /// <summary>
        /// The migration '{name}' has already been applied to the database. Unapply it and try again. If the migration has been applied to other databases, consider reverting its changes using a new migration.
        /// </summary>
        public static string UnapplyMigration([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnapplyMigration", "name"), name);
        }

        /// <summary>
        /// The current CSharpMigrationOperationGenerator cannot scaffold operations of type '{operationType}'. Configure your services to use one that can.
        /// </summary>
        public static string UnknownOperation([CanBeNull] object operationType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnknownOperation", "operationType"), operationType);
        }

        /// <summary>
        /// The current CSharpHelper cannot scaffold literals of type '{literalType}'. Configure your services to use one that can.
        /// </summary>
        public static string UnknownLiteral([CanBeNull] object literalType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnknownLiteral", "literalType"), literalType);
        }

        /// <summary>
        /// Unable to find provider assembly with name {assemblyName}. Ensure the specified name is correct and is referenced by the project.
        /// </summary>
        public static string CannotFindRuntimeProviderAssembly([CanBeNull] object assemblyName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotFindRuntimeProviderAssembly", "assemblyName"), assemblyName);
        }

        /// <summary>
        /// An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
        /// </summary>
        public static string DestructiveOperation
        {
            get { return GetString("DestructiveOperation"); }
        }

        /// <summary>
        /// Reusing directory of file '{file}'.
        /// </summary>
        public static string ReusingDirectory([CanBeNull] object file)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ReusingDirectory", "file"), file);
        }

        /// <summary>
        /// Writing migration to '{file}'.
        /// </summary>
        public static string WritingMigration([CanBeNull] object file)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("WritingMigration", "file"), file);
        }

        /// <summary>
        /// Writing model snapshot to '{file}'.
        /// </summary>
        public static string WritingSnapshot([CanBeNull] object file)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("WritingSnapshot", "file"), file);
        }

        /// <summary>
        /// Done.
        /// </summary>
        public static string Done
        {
            get { return GetString("Done"); }
        }

        /// <summary>
        /// Reusing namespace of type '{type}'.
        /// </summary>
        public static string ReusingNamespace([CanBeNull] object type)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ReusingNamespace", "type"), type);
        }

        /// <summary>
        /// Reusing model snapshot name '{name}'.
        /// </summary>
        public static string ReusingSnapshotName([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ReusingSnapshotName", "name"), name);
        }

        /// <summary>
        /// Unable to find design-time provider assembly. Please install the {designTimeProviderAssemblyName} NuGet package and ensure that the package is referenced by the project.
        /// </summary>
        public static string CannotFindDesignTimeProviderAssembly([CanBeNull] object designTimeProviderAssemblyName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotFindDesignTimeProviderAssembly", "designTimeProviderAssemblyName"), designTimeProviderAssemblyName);
        }

        /// <summary>
        /// Unable to find expected assembly attribute named {attributeName} in provider assembly {runtimeProviderAssemblyName}. This attribute is required to identify the class which acts as the design-time service provider factory.
        /// </summary>
        public static string CannotFindDesignTimeProviderAssemblyAttribute([CanBeNull] object attributeName, [CanBeNull] object runtimeProviderAssemblyName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotFindDesignTimeProviderAssemblyAttribute", "attributeName", "runtimeProviderAssemblyName"), attributeName, runtimeProviderAssemblyName);
        }

        /// <summary>
        /// {provider} is not a Relational provider and therefore cannot be use with Migrations.
        /// </summary>
        public static string NonRelationalProvider([CanBeNull] object provider)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NonRelationalProvider", "provider"), provider);
        }

        /// <summary>
        /// Could not load assembly '{assembly}'. Ensure it is referenced by the startup project '{startupProject}'.
        /// </summary>
        public static string UnreferencedAssembly([CanBeNull] object assembly, [CanBeNull] object startupProject)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnreferencedAssembly", "assembly", "startupProject"), assembly, startupProject);
        }

        /// <summary>
        /// Finding DbContext classes...
        /// </summary>
        public static string LogFindingContexts
        {
            get { return GetString("LogFindingContexts"); }
        }

        /// <summary>
        /// The namespace '{migrationsNamespace}' contains migrations for a different DbContext. This can result in conflicting migration names. It's reccommend to put migrations for different DbContext classes into different namespaces.
        /// </summary>
        public static string ForeignMigrations([CanBeNull] object migrationsNamespace)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ForeignMigrations", "migrationsNamespace"), migrationsNamespace);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
