﻿using System;

namespace behaviac
{
	// Token: 0x020036E1 RID: 14049
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Monster_Nongbao_Nongbao_Event_node16 : Condition
	{
		// Token: 0x060155D8 RID: 87512 RVA: 0x006720FE File Offset: 0x006704FE
		public Condition_bt_Monster_AI_Monster_Nongbao_Nongbao_Event_node16()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.LessThan;
			this.opl_p2 = 0.25f;
		}

		// Token: 0x060155D9 RID: 87513 RVA: 0x00672120 File Offset: 0x00670520
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EFAB RID: 61355
		private HMType opl_p0;

		// Token: 0x0400EFAC RID: 61356
		private BE_Operation opl_p1;

		// Token: 0x0400EFAD RID: 61357
		private float opl_p2;
	}
}
