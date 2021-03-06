﻿using EPiServer.Core;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FakeMaker.Commerce")]

namespace EPiFakeMaker
{
    public abstract class Fake : IFake
    {
        public abstract IList<IFake> Children { get; }
        public abstract IContent Content { get; protected set; }

        internal abstract void HelpCreatingMockForCurrentType(IFakeMaker maker);
    }
}
