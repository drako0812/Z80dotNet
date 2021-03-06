﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "LD (HL),n +        .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The LD (HL),n instruction.
        /// </summary>
        private byte LD_aHL_N()
        {
            var newValue = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.HL.ToUShort();
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 10;
        }

        /// <summary>
        /// The LD (IX+n),n instruction.
        /// </summary>
        private byte LD_aIX_plus_n_N()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
            var newValue = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.IX.ToUShort().Add(offset.ToSignedByte());
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

        /// <summary>
        /// The LD (IY+n),n instruction.
        /// </summary>
        private byte LD_aIY_plus_n_N()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
            var newValue = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.IY.ToUShort().Add(offset.ToSignedByte());
				ProcessorAgent.WriteToMemory(address, newValue);
    
            return 19;
        }

    }
}
