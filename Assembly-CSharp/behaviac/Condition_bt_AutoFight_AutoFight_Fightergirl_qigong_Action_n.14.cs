﻿using System;

namespace behaviac
{
	// Token: 0x02001F04 RID: 7940
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fightergirl_qigong_Action_node73 : Condition
	{
		// Token: 0x060127AC RID: 75692 RVA: 0x005681C5 File Offset: 0x005665C5
		public Condition_bt_AutoFight_AutoFight_Fightergirl_qigong_Action_node73()
		{
			this.opl_p0 = 0.2f;
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x005681D8 File Offset: 0x005665D8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C1A3 RID: 49571
		private float opl_p0;
	}
}
