﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "INC r +         .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The INC A instruction.
        /// </summary>
        private byte INC_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = oldValue.Inc();
            Registers.A = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC A instruction.
        /// </summary>
        private byte DEC_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = oldValue.Dec();
            Registers.A = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC B instruction.
        /// </summary>
        private byte INC_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var newValue = oldValue.Inc();
            Registers.B = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC B instruction.
        /// </summary>
        private byte DEC_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var newValue = oldValue.Dec();
            Registers.B = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC C instruction.
        /// </summary>
        private byte INC_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var newValue = oldValue.Inc();
            Registers.C = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC C instruction.
        /// </summary>
        private byte DEC_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var newValue = oldValue.Dec();
            Registers.C = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC D instruction.
        /// </summary>
        private byte INC_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var newValue = oldValue.Inc();
            Registers.D = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC D instruction.
        /// </summary>
        private byte DEC_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var newValue = oldValue.Dec();
            Registers.D = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC E instruction.
        /// </summary>
        private byte INC_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var newValue = oldValue.Inc();
            Registers.E = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC E instruction.
        /// </summary>
        private byte DEC_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var newValue = oldValue.Dec();
            Registers.E = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC H instruction.
        /// </summary>
        private byte INC_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var newValue = oldValue.Inc();
            Registers.H = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC H instruction.
        /// </summary>
        private byte DEC_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var newValue = oldValue.Dec();
            Registers.H = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC L instruction.
        /// </summary>
        private byte INC_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var newValue = oldValue.Inc();
            Registers.L = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The DEC L instruction.
        /// </summary>
        private byte DEC_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var newValue = oldValue.Dec();
            Registers.L = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The INC IXH instruction.
        /// </summary>
        private byte INC_IXH()
        {
            FetchFinished();

            var oldValue = Registers.IXH;
	        var newValue = oldValue.Inc();
            Registers.IXH = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The DEC IXH instruction.
        /// </summary>
        private byte DEC_IXH()
        {
            FetchFinished();

            var oldValue = Registers.IXH;
	        var newValue = oldValue.Dec();
            Registers.IXH = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The INC IXL instruction.
        /// </summary>
        private byte INC_IXL()
        {
            FetchFinished();

            var oldValue = Registers.IXL;
	        var newValue = oldValue.Inc();
            Registers.IXL = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The DEC IXL instruction.
        /// </summary>
        private byte DEC_IXL()
        {
            FetchFinished();

            var oldValue = Registers.IXL;
	        var newValue = oldValue.Dec();
            Registers.IXL = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The INC IYH instruction.
        /// </summary>
        private byte INC_IYH()
        {
            FetchFinished();

            var oldValue = Registers.IYH;
	        var newValue = oldValue.Inc();
            Registers.IYH = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The DEC IYH instruction.
        /// </summary>
        private byte DEC_IYH()
        {
            FetchFinished();

            var oldValue = Registers.IYH;
	        var newValue = oldValue.Dec();
            Registers.IYH = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The INC IYL instruction.
        /// </summary>
        private byte INC_IYL()
        {
            FetchFinished();

            var oldValue = Registers.IYL;
	        var newValue = oldValue.Inc();
            Registers.IYL = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The DEC IYL instruction.
        /// </summary>
        private byte DEC_IYL()
        {
            FetchFinished();

            var oldValue = Registers.IYL;
	        var newValue = oldValue.Dec();
            Registers.IYL = newValue;
	
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 8;
        }

        /// <summary>
        /// The INC (HL) instruction.
        /// </summary>
        private byte INC_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var newValue = oldValue.Inc();
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 11;
        }

        /// <summary>
        /// The DEC (HL) instruction.
        /// </summary>
        private byte DEC_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var newValue = oldValue.Dec();
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 11;
        }

        /// <summary>
        /// The INC (IX+n) instruction.
        /// </summary>
        private byte INC_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.IX.ToUShort().Add(offset.ToSignedByte());
			var oldValue = ProcessorAgent.ReadFromMemory(address);
	        var newValue = oldValue.Inc();
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 23;
        }

        /// <summary>
        /// The DEC (IX+n) instruction.
        /// </summary>
        private byte DEC_aIX_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.IX.ToUShort().Add(offset.ToSignedByte());
			var oldValue = ProcessorAgent.ReadFromMemory(address);
	        var newValue = oldValue.Dec();
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 23;
        }

        /// <summary>
        /// The INC (IY+n) instruction.
        /// </summary>
        private byte INC_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.IY.ToUShort().Add(offset.ToSignedByte());
			var oldValue = ProcessorAgent.ReadFromMemory(address);
	        var newValue = oldValue.Inc();
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x00);
            Registers.PF = (newValue == 0x80);
            Registers.NF = 0;
			SetFlags3and5From(newValue);

            return 23;
        }

        /// <summary>
        /// The DEC (IY+n) instruction.
        /// </summary>
        private byte DEC_aIY_plus_n()
        {
			var offset = ProcessorAgent.FetchNextOpcode();
            FetchFinished();

			var address = Registers.IY.ToUShort().Add(offset.ToSignedByte());
			var oldValue = ProcessorAgent.ReadFromMemory(address);
	        var newValue = oldValue.Dec();
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = ((newValue & 0x0F) == 0x0F);
            Registers.PF = (newValue == 0x7F);
            Registers.NF = 1;
			SetFlags3and5From(newValue);

            return 23;
        }

    }
}