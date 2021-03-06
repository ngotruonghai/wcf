// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Xml.Serialization
{
    using System;

    /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember"]/*' />
    ///<internalonly/>
    /// <devdoc>
    ///    <para>[To be supplied.]</para>
    /// </devdoc>
    public class XmlReflectionMember
    {
        private string _memberName;
        private Type _type;
        private XmlAttributes _xmlAttributes = new XmlAttributes();
        private SoapAttributes _soapAttributes = new SoapAttributes();
        private bool _isReturnValue;
        private bool _overrideIsNullable;

        /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember.MemberType"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public Type MemberType
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember.XmlAttributes"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public XmlAttributes XmlAttributes
        {
            get { return _xmlAttributes; }
            set { _xmlAttributes = value; }
        }

        /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember.SoapAttributes"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public SoapAttributes SoapAttributes
        {
            get { return _soapAttributes; }
            set { _soapAttributes = value; }
        }

        /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember.MemberName"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public string MemberName
        {
            get { return _memberName == null ? string.Empty : _memberName; }
            set { _memberName = value; }
        }

        /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember.IsReturnValue"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public bool IsReturnValue
        {
            get { return _isReturnValue; }
            set { _isReturnValue = value; }
        }

        /// <include file='doc\XmlReflectionMember.uex' path='docs/doc[@for="XmlReflectionMember.OverrideIsNullable"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public bool OverrideIsNullable
        {
            get { return _overrideIsNullable; }
            set { _overrideIsNullable = value; }
        }
    }
}
