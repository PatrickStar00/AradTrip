﻿using System;

namespace behaviac
{
	// Token: 0x0200370B RID: 14091
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Niutou_niutouhuwei_Niutou_niutouhuwei_Event_Hundun_node3 : Condition
	{
		// Token: 0x06015624 RID: 87588 RVA: 0x006739EB File Offset: 0x00671DEB
		public Condition_bt_Monster_AI_Niutou_niutouhuwei_Niutou_niutouhuwei_Event_Hundun_node3()
		{
			this.opl_p0 = 2000;
			this.opl_p1 = 1;
			this.opl_p2 = 1000;
			this.opl_p3 = 1000;
		}

		// Token: 0x06015625 RID: 87589 RVA: 0x00673A1C File Offset: 0x00671E1C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EFEB RID: 61419
		private int opl_p0;

		// Token: 0x0400EFEC RID: 61420
		private int opl_p1;

		// Token: 0x0400EFED RID: 61421
		private int opl_p2;

		// Token: 0x0400EFEE RID: 61422
		private int opl_p3;
	}
}
