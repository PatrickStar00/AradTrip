﻿using System;

namespace behaviac
{
	// Token: 0x02003848 RID: 14408
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Action_node24 : Condition
	{
		// Token: 0x06015876 RID: 88182 RVA: 0x0067F31A File Offset: 0x0067D71A
		public Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Action_node24()
		{
			this.opl_p0 = 0.33f;
		}

		// Token: 0x06015877 RID: 88183 RVA: 0x0067F330 File Offset: 0x0067D730
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F234 RID: 62004
		private float opl_p0;
	}
}
