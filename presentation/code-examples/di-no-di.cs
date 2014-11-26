public class ServiceUser {
	public ServiceUser() {}

	public int SomeMethod(int p) {
		var service = new Service();
		if (p == 0) {
			return service.OtherMethod(p);
		}
		return service.DifferentMethod(p);
	}
}