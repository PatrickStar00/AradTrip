﻿using System;

namespace behaviac
{
	// Token: 0x02002D82 RID: 11650
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_65Tuanben_Dajisi_Boss_ACTION_node14 : Condition
	{
		// Token: 0x060143E6 RID: 82918 RVA: 0x00614992 File Offset: 0x00612D92
		public Condition_bt_Monster_AI_65Tuanben_Dajisi_Boss_ACTION_node14()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.GreaterThanOrEqualTo;
			this.opl_p2 = 0.15f;
		}

		// Token: 0x060143E7 RID: 82919 RVA: 0x006149B4 File Offset: 0x00612DB4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DDB7 RID: 56759
		private HMType opl_p0;

		// Token: 0x0400DDB8 RID: 56760
		private BE_Operation opl_p1;

		// Token: 0x0400DDB9 RID: 56761
		private float opl_p2;
	}
}
