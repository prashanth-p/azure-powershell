namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20200730Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>
    /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
    /// </summary>
    public partial class MachineExtensionUpdatePropertiesProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20200730Preview.IMachineExtensionUpdatePropertiesProtectedSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20200730Preview.IMachineExtensionUpdatePropertiesProtectedSettingsInternal
    {

        /// <summary>
        /// Creates an new <see cref="MachineExtensionUpdatePropertiesProtectedSettings" /> instance.
        /// </summary>
        public MachineExtensionUpdatePropertiesProtectedSettings()
        {

        }
    }
    /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
    public partial interface IMachineExtensionUpdatePropertiesProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {

    }
    /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
    internal partial interface IMachineExtensionUpdatePropertiesProtectedSettingsInternal

    {

    }
}