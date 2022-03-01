﻿using System;

namespace behaviac
{
	// Token: 0x02003D85 RID: 15749
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_hard_Shuiren_Boss_hard_node20 : Condition
	{
		// Token: 0x0601629F RID: 90783 RVA: 0x006B3049 File Offset: 0x006B1449
		public Condition_bt_Monster_AI_Tuanben_hard_Shuiren_Boss_hard_node20()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.LessThanOrEqualTo;
			this.opl_p2 = 0.4f;
		}

		// Token: 0x060162A0 RID: 90784 RVA: 0x006B306C File Offset: 0x006B146C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FAF2 RID: 64242
		private HMType opl_p0;

		// Token: 0x0400FAF3 RID: 64243
		private BE_Operation opl_p1;

		// Token: 0x0400FAF4 RID: 64244
		private float opl_p2;
	}
}
