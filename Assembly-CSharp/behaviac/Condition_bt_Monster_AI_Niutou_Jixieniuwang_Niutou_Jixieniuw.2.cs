﻿using System;

namespace behaviac
{
	// Token: 0x020036F9 RID: 14073
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Niutou_Jixieniuwang_Niutou_Jixieniuwang_Zhaohuan_wudi_node7 : Condition
	{
		// Token: 0x06015601 RID: 87553 RVA: 0x00672F99 File Offset: 0x00671399
		public Condition_bt_Monster_AI_Niutou_Jixieniuwang_Niutou_Jixieniuwang_Zhaohuan_wudi_node7()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.LessThanOrEqualTo;
			this.opl_p2 = 0.7f;
		}

		// Token: 0x06015602 RID: 87554 RVA: 0x00672FBC File Offset: 0x006713BC
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EFC6 RID: 61382
		private HMType opl_p0;

		// Token: 0x0400EFC7 RID: 61383
		private BE_Operation opl_p1;

		// Token: 0x0400EFC8 RID: 61384
		private float opl_p2;
	}
}
