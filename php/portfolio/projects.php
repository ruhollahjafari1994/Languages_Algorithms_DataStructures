<?php include 'db.php'; ?>
<div class="projects">
    <?php
    $sql = "SELECT * FROM projects";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        while($row = $result->fetch_assoc()) {
            echo "<div class='project'>";
            echo "<h3>" . $row["title"] . "</h3>";
            echo "<p>" . $row["description"] . "</p>";
            echo "<img src='" . $row["image"] . "' alt='" . $row["title"] . "'>";
            echo "<a href='" . $row["url"] . "'>View Project</a>";
            echo "</div>";
        }
    } else {
        echo "<p>No projects found.</p>";
    }
    $conn->close();
    ?>
</div>
