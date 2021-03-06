// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Ascensio System Limited" file="Access.cs">
// //   
// // </copyright>
// // <summary>
// //   (c) Copyright Ascensio System Limited 2008-2012
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace ASC.Xmpp.Core.protocol.extensions.pubsub
{
    /*
        <xs:attribute name='access' use='optional' default='open'>
            <xs:simpleType>
              <xs:restriction base='xs:NCName'>
                <xs:enumeration value='authorize'/>
                <xs:enumeration value='open'/>
                <xs:enumeration value='presence'/>
                <xs:enumeration value='roster'/>
                <xs:enumeration value='whitelist'/>
              </xs:restriction>
            </xs:simpleType>
        </xs:attribute>
    */

    public enum Access
    {
        NONE = -1,
        open,
        authorize,
        presence,
        roster,
        whitelist
    }
}