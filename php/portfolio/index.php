<?php include 'db.php'; ?>
<!DOCTYPE html>
<html>
<head>
    <title>My Portfolio</title>
</head>
<body>
    <h1>My Projects</h1>
    <div>
        <?php
        $sql = "SELECT * FROM projects";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) {
            while($row = $result->fetch_assoc()) {
                echo "<div>";
                echo "<h2>" . $row["title"] . "</h2>";
                echo "<p>" . $row["description"] . "</p>";
                echo "<img src='" . $row["image"] . "' alt='" . $row["title"] . "'>";
                echo "<a href='" . $row["url"] . "'>View Project</a>";
                echo "</div>";
            }
        } else {
            echo "0 results";
        }
        $conn->close();
        ?>
    </div>
</body>
</html>
