import java.util.stream.IntStream;
import java.util.List;

public class Challenge {
	public static int countTrue(boolean[] arr) {
		List<Boolean> values = Lists.newArrayList(arr);

    long count = values.stream().filter(p -> p == true).count();
		return (int)count;
	}
}
